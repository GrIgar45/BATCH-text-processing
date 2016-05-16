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
    private readonly List<FileDirectory> _directories = new List<FileDirectory>();
    private readonly List<string> _fileList = new List<string>();

    public FileDirectory(string folder, ref List<string> pathList) {
      _fileList.AddRange(Directory.GetFiles(folder));
      var directories = Directory.GetDirectories(folder);
      if (directories.Length != 0) {
        foreach (var directory in directories) {
          _directories.Add(new FileDirectory(directory, ref pathList));
        }
      }
      pathList.AddRange(_fileList); // fill the list for view in listBox
    }

    public void SearchTextInFiles(string filter, ref List<string> pathList) {
      foreach (var fileDirectory in _directories) {
        fileDirectory.SearchTextInFiles(filter, ref pathList);
      }
      pathList.AddRange(_fileList.Where(filePath => Search(filePath, filter)));
    }

    private static bool Search(string filePath, string searchText) {
      Encoding en;
      var content = GetContent(filePath, out en);
      return content != null && Regex.IsMatch(content, searchText); // no content or not contain text? nothing to do here!
    }

    public void ReplaceTextInFiles(string searchText, string replaceText, ListView.CheckedListViewItemCollection listCollection) {
      foreach (var directory in _directories) {
        directory.ReplaceTextInFiles(searchText, replaceText, listCollection);
      }
      foreach (var file in _fileList) {
        Replace(file, searchText, replaceText, listCollection);
      }
    }

    private static void Replace(string filePath, string searchText, string replaceText,
      IEnumerable listCollection) {
      Encoding en;
      var content = GetContent(filePath, out en);
      if (content == null || listCollection.Cast<ListViewItem>().All(item => item.Text != filePath)) return; // Unknown encoding or not selected path? nothing to do here!

      content = Regex.Replace(content, searchText, replaceText);
      File.WriteAllText(filePath, content, en);
    }

    private static string GetContent(string filePath, out Encoding en) {
      string content;
      en = DetectEncoding(filePath);
      if (en == null) return null;

      using (var reader = new StreamReader(filePath, en))
        content = reader.ReadToEnd();
      return content;
    }

    private static Encoding DetectEncoding(string filePath) {
      var cd = new CharsetDetector(); // using UDE library, object to detect encoding, dem i love this!!
      using (var fStream = File.OpenRead(filePath)) {
        cd.Feed(fStream);
        cd.DataEnd(); // I dont know why, but this methot should be execudet
      }
      return cd.Charset == null ? null : Encoding.GetEncoding(cd.Charset); //return find encoding or null if it unknow encoding
    }
  }
}
