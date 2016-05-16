using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class View : Form {
    private List<string> _pathList;
    private string _currentForder;
    private FileDirectory _fileDirectory;

    public View() {
      InitializeComponent();
    }

    /// <summary>
    /// Обработка нажатия клавиши поиска
    /// </summary>
    private void search_Click(object sender, EventArgs e) {
      _pathList = new List<string>();
      try {
        _fileDirectory.SearchTextInFiles(searchBox.Text, ref _pathList);
      }
      catch (FileNotFoundException) {
        MessageBox.Show(@"Структура каталога была изменeна");
        SetDirectiryPathError(string.Empty);
        checkView.Clear();
        return;
      }
      FillListOfFile();
    }

    /// <summary>
    /// Обработка нажатия клавиши замены
    /// </summary>
    private void replace_Click(object sender, EventArgs e) {
      try {
        _fileDirectory.ReplaceTextInFiles(searchBox.Text, replaceBox.Text, checkView.CheckedItems);
      }
      catch (FileNotFoundException) {
        MessageBox.Show(@"Структура каталога была изменeна");
        SetDirectiryPathError(string.Empty);
        checkView.Clear();
      }
    }

    /// <summary>
    /// Выход
    /// </summary>
    private void quit_Click(object sender, EventArgs e) {
      Close();
    }

    private void about_Click(object sender, EventArgs e) {
      var ab = new AboutBox1();
      ab.ShowDialog();
    }
  }
}