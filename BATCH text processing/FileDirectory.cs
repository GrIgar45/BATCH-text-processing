using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ude;

namespace BATCH_text_processing {
  class FileDirectory {
    private List<FileDirectory> _directories = new List<FileDirectory>();
    private List<string> _filleList = new List<string>();
    private string _searchText, _replaceText;

    public FileDirectory(string folder) {
      _filleList.AddRange(Directory.GetFiles(folder));
      var directories = Directory.GetDirectories(folder);
      if (directories.Length == 0) return;
      foreach (var directory in directories) {
        _directories.Add(new FileDirectory(directory));
      }
    }

    public void ReplaceTextInFilles(string searchText, string replaceText) {
      _searchText = searchText;
      _replaceText = replaceText;
      foreach (var fille in _filleList) {
        Replace(fille);
      }
      if (_directories == null) return;
      foreach (var directory in _directories) {
        directory.ReplaceTextInFilles(_searchText, _replaceText);
      }
    }
    private void Replace(string filePath) {
      string content;
      var en = DetectEncoding(filePath);
      if (en == null) return; //Unknown encoding? nothing to do here!

      using (var reader = new StreamReader(filePath, en))
        content = reader.ReadToEnd();

      content = Regex.Replace(content, _searchText, _replaceText);
      File.WriteAllText(filePath, content);
    }

    private Encoding DetectEncoding(string filePath) {
      var cd = new CharsetDetector();
      using (var fStream = File.OpenRead(filePath)) {
        cd.Feed(fStream);
        cd.DataEnd();
      }
      return cd.Charset == null ? null : Encoding.GetEncoding(cd.Charset);
    }
  }
}
