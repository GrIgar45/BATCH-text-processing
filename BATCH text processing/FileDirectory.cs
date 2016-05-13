using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
      foreach (var fille in FilleList) {
        Replace(fille);
      }
      if (_directories == null) return;
      foreach (var directory in _directories) {
        directory.ReplaceTextInFilles(_searchText, _replaceText);
      }
    }
    private void Replace(string filePath) {
      string content;
      using (var reader = new StreamReader(filePath))
        content = reader.ReadToEnd();
      if (!Regex.IsMatch(content, _searchText)) return;
      content = Regex.Replace(content, _searchText, _replaceText);
      using (var writer = new StreamWriter(filePath))
        writer.Write(content);
    }

    public List<string> FilleList => _filleList;
  }
}
