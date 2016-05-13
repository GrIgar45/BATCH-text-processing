using System;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class View : Form {
    public View() {
      InitializeComponent();
    }

    private void ChoseDirectory_Click(object sender, EventArgs e) {
      var openDialog = new FolderBrowserDialog();
      openDialog.ShowNewFolderButton = false;
      if (openDialog.ShowDialog() != DialogResult.OK) return;
      Model.SetMainFolder(openDialog.SelectedPath);
      statusLabel.Text = openDialog.SelectedPath;
    }

    private void replace_Click(object sender, EventArgs e) {
      Model.StartProcessing(searchBox.Text, replaceBox.Text);
    }
  }
}
