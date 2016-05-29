using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ude;

namespace BATCH_text_processing {
  internal class FileDirectory {
    // UDE library is has a small problem with the encoding detection
    // It had to manually override some values
    private static readonly Dictionary<string, string> EncodingDictionary = new Dictionary<string, string>() {
      {"x-mac-cyrillic", "windows-1251"},
    };
    private readonly List<FileDirectory> _directories = new List<FileDirectory>();
    private readonly List<string> _fileList = new List<string>();
    

    /// <summary>
    /// Инициализирует объект каталога
    /// </summary>
    /// <param name="folder">Адресс пути к директории</param>
    /// <param name="pathList">Список всех файлов</param>
    /// <param name="searchPattern"></param>
    public FileDirectory(string folder, ref List<string> pathList, string searchPattern) {
      _fileList.AddRange(Directory.GetFiles(folder, searchPattern));
      var directories = Directory.GetDirectories(folder);
      foreach (var directory in directories)
        _directories.Add(new FileDirectory(directory, ref pathList, searchPattern));
      pathList.AddRange(_fileList); // fill the list for view in listBox
    }

        private LogWriter LogWriter {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }

        /// <summary>
        /// Поиск по каталогу
        /// </summary>
        /// <param name="searchText">Поисковой запрос</param>
        /// <param name="pathList">Список подходящих файлов</param>
        /// <param name="logWriter"></param>
        public void SearchTextInFiles(string searchText, ref List<string> pathList, LogWriter logWriter) {
      foreach (var fileDirectory in _directories) {
        fileDirectory.SearchTextInFiles(searchText, ref pathList, logWriter);
      }
      pathList.AddRange(_fileList.Where(filePath => Search(filePath, searchText, logWriter)));
    }

    /// <summary>
    /// Поиск в файле
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="logWriter"></param>
    /// <returns></returns>
    private static bool Search(string filePath, string searchText, LogWriter logWriter) {
      Encoding en;
      var content = GetContent(filePath, out en);
      // not contain text? nothing to do here!
      if (en == null) {
        logWriter.AddLog(filePath, $"не подходящий формат");
        return false;
      }
      var result = Regex.IsMatch(content, searchText);
      logWriter.AddLog(filePath, result ? "найдено" : "не найдено");
      return result;
    }

    /// <summary>
    /// Замена текста в каталоге
    /// </summary>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="replaceText">Заменяемый текст</param>
    /// <param name="listCollection">Колекция отмеченых пользователем файлов для обработки</param>
    /// <param name="logWriter"></param>
    public int ReplaceTextInFiles(string searchText, string replaceText,
      ListView.CheckedListViewItemCollection listCollection, LogWriter logWriter) {
      var i =
        _directories.Sum(directory => directory.ReplaceTextInFiles(searchText, replaceText, listCollection, logWriter)) +
        _fileList.Sum(file => Replace(file, searchText, replaceText, listCollection, logWriter));
      return i;
    }

    /// <summary>
    /// Замена текста в файле
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="replaceText">Заменяемый текст</param>
    /// <param name="listCollection">Колекция отмеченых пользователем файлов для обработки</param>
    /// <param name="logWriter"></param>
    private static int Replace(string filePath, string searchText, string replaceText, IEnumerable listCollection, LogWriter logWriter) {
      Encoding en;
      var content = GetContent(filePath, out en);
      if (content == null || listCollection.Cast<ListViewItem>().All(item => item.Text != filePath)) {
        logWriter.AddLog(filePath, "Неверный формат");
        return 0; // Unknown encoding or not selected path? nothing to do here!
      }
      var contain = Regex.IsMatch(content, searchText);
      logWriter.AddLog(filePath, contain? $"Заменено \"{searchText}\" на \"{replaceText}\"": "Не найдено соотвествий");
      if (!contain) return 0;
      content = Regex.Replace(content, searchText, replaceText);
      File.WriteAllText(filePath, content, en);
      return 1;
    }

    /// <summary>
    /// Считывание текста
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="en">Кодировка файла</param>
    /// <returns>Текст файла</returns>
    private static string GetContent(string filePath, out Encoding en) {
      en = DetectEncoding(filePath);
      return en == null ? null : File.ReadAllText(filePath, en);
    }

    /// <summary>
    /// Определение кодировки файла
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <returns>Кодирока (null если не расспознана)</returns>
    private static Encoding DetectEncoding(string filePath) {
      var cd = new CharsetDetector(); // using UDE library, object to detect encoding, dem i love it!!
      using (var fStream = File.OpenRead(filePath)) {
        cd.Feed(fStream);
        cd.DataEnd(); // I dont know why, but this method should be executed
      }
      
      if (cd.Charset != null)  // return find encoding 
        return EncodingDictionary.ContainsKey(cd.Charset) ? Encoding.GetEncoding(EncodingDictionary[cd.Charset]) : Encoding.GetEncoding(cd.Charset);
      return null; // or null if it unknow encoding
    }
  }
}
