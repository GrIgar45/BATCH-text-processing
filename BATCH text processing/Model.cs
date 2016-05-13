using System;

namespace BATCH_text_processing {
  static class Model {
    private static string _currentForder;
    private static FileDirectory _fileDirectory;

    public static void SetMainFolder(string folder) => _currentForder = folder;

    public static void StartProcessing(string searchText, string replaceText) {
      _fileDirectory = new FileDirectory(_currentForder);
      _fileDirectory.ReplaceTextInFilles(searchText, replaceText);
    }

    
  }
}
