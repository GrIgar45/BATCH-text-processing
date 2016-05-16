using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class View : Form {
    private List<string> _pathList;
    private string _currentForder;
    private FileDirectory _fileDirectory;

    public View() {
      InitializeComponent();
    }

    private void search_Click(object sender, EventArgs e) {
      _pathList = new List<string>();
      _fileDirectory.SearchTextInFiles(searchBox.Text, ref _pathList);
      FillListOfFile();
    }

    private void replace_Click(object sender, EventArgs e) {
      _fileDirectory.ReplaceTextInFiles(searchBox.Text, replaceBox.Text, checkView.CheckedItems);
      foreach (ListViewItem item in checkView.CheckedItems) {
        
      }
    }

    private void quit_Click(object sender, EventArgs e) {
      Close();
    }
  }
}