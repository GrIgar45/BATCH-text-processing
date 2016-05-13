using System;
using System.IO;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class View : Form {
    private static string _currentForder;
    private static FileDirectory _fileDirectory;
    public View() {
      InitializeComponent();
    }

    private void ChoseDirectory_Click(object sender, EventArgs e) {
      var openDialog = new FolderBrowserDialog {ShowNewFolderButton = false};
      if (openDialog.ShowDialog() != DialogResult.OK) return;
      _currentForder = openDialog.SelectedPath;
      statusLabel.Text = openDialog.SelectedPath;
      replace.Enabled = true;
    }

    private void replace_Click(object sender, EventArgs e) {
      if (!Directory.Exists(_currentForder)) {
        MessageBox.Show(@"Выбраной папки не существует");
        return;
      }
      StartProcessing(_currentForder, searchBox.Text, replaceBox.Text);
    }
    public static void StartProcessing(string mainDirectory, string searchText, string replaceText) {
      _fileDirectory = new FileDirectory(mainDirectory);
      _fileDirectory.ReplaceTextInFilles(searchText, replaceText);
    }
  }
}
