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
    /// Число файлов в каталоге
    /// </summary>
    public static int FilesCount { get; set; } = 0;

    /// <summary>
    /// Инициализирует объект каталога
    /// </summary>
    /// <param name="folder">Адресс пути к директории</param>
    /// <param name="pathList">Список всех файлов</param>
    public FileDirectory(string folder, ref List<string> pathList) {
      _fileList.AddRange(Directory.GetFiles(folder));
      FilesCount += _fileList.Count;
      var directories = Directory.GetDirectories(folder);
      foreach (var directory in directories)
        _directories.Add(new FileDirectory(directory, ref pathList));
      pathList.AddRange(_fileList); // fill the list for view in listBox
    }

    /// <summary>
    /// Поиск по каталогу
    /// </summary>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="pathList">Список подходящих файлов</param>
    public void SearchTextInFiles(string searchText, ref List<string> pathList) {
      foreach (var fileDirectory in _directories) {
        fileDirectory.SearchTextInFiles(searchText, ref pathList);
      }
      pathList.AddRange(_fileList.Where(filePath => Search(filePath, searchText)));
    }

    /// <summary>
    /// Поиск в файле
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="searchText">Поисковой запрос</param>
    /// <returns></returns>
    private static bool Search(string filePath, string searchText) {
      Encoding en;
      var content = GetContent(filePath, out en);
      return content != null && Regex.IsMatch(content, searchText);
        // no content or not contain text? nothing to do here!
    }

    /// <summary>
    /// Замена текста в каталоге
    /// </summary>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="replaceText">Заменяемый текст</param>
    /// <param name="listCollection">Колекция отмеченых пользователем файлов для обработки</param>
    public void ReplaceTextInFiles(string searchText, string replaceText,
      ListView.CheckedListViewItemCollection listCollection) {
      foreach (var directory in _directories) {
        directory.ReplaceTextInFiles(searchText, replaceText, listCollection);
      }
      foreach (var file in _fileList) {
        Replace(file, searchText, replaceText, listCollection);
      }
    }

    /// <summary>
    /// Замена текста в файле
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="searchText">Поисковой запрос</param>
    /// <param name="replaceText">Заменяемый текст</param>
    /// <param name="listCollection">Колекция отмеченых пользователем файлов для обработки</param>
    private static void Replace(string filePath, string searchText, string replaceText,
      IEnumerable listCollection) {
      Encoding en;
      var content = GetContent(filePath, out en);
      if (content == null || listCollection.Cast<ListViewItem>().All(item => item.Text != filePath))
        return; // Unknown encoding or not selected path? nothing to do here!

      content = Regex.Replace(content, searchText, replaceText);
      File.WriteAllText(filePath, content, en);
    }

    /// <summary>
    /// Считывание текста
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    /// <param name="en">Кодировка файла</param>
    /// <returns>Текст файла</returns>
    private static string GetContent(string filePath, out Encoding en) {
      string content;
      en = DetectEncoding(filePath);
      if (en == null) return null;
      // Read all -f-*-c-k-*-g- text from file 
      using (var reader = new StreamReader(filePath, en))
        content = reader.ReadToEnd();
      return content;
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
