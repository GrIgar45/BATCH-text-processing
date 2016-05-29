using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class MainForm : Form {
    private List<string> _pathList;
    private string _currentForder;
    private FileDirectory _fileDirectory;

    public MainForm() {
      InitializeComponent();
    }

        private AboutForm AboutForm {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }

        /// <summary>
        /// Обработка нажатия клавиши поиска
        /// </summary>
        private void Search_Click(object sender, EventArgs e) {
      _pathList = new List<string>();
      try {
        Cursor = Cursors.WaitCursor;
        var lw = new LogWriter(_currentForder, $"Поиск по ключевому слову:\n\"{searchBox.Text}\"");
        _fileDirectory.SearchTextInFiles(searchBox.Text, ref _pathList, lw);
        MessageBox.Show($"Кол-во найденых по запросу файлов:\n{_pathList.Count}", @"Поиск завершен");
        lw.WriteLog();
      }
      catch (FileNotFoundException) {
        MessageBox.Show(@"Структура каталога была изменeна", @"Ошибка");
        SetDirectiryPathError(string.Empty);
        refreshButton.Enabled = true;
        checkView.Clear();
        return;
      }
      catch (ArgumentException) {
        MessageBox.Show(@"Произошла ошибка синтаксического анализа регулярного выражения.", @"Ошибка");
      }
      finally {
        Cursor = Cursors.Arrow;
      }
      FillListOfFile();
      GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
    }

    /// <summary>
    /// Обработка нажатия клавиши замены
    /// </summary>
    private void Replace_Click(object sender, EventArgs e) {
      try {
        this.Cursor = Cursors.WaitCursor;
        var lw = new LogWriter(_currentForder, $"Замена по ключевому слову:\n\"{searchBox.Text}\"");
        var i = _fileDirectory.ReplaceTextInFiles(searchBox.Text, replaceBox.Text, checkView.CheckedItems, lw);
        lw.WriteLog();
        MessageBox.Show($"Кол-во замен :\n{i}", @"Замена завершена");
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
      }
      catch (FileNotFoundException) {
        MessageBox.Show(@"Структура каталога была изменeна");
        SetDirectiryPathError(string.Empty);
        refreshButton.Enabled = true;
        checkView.Clear();
      }
      catch (ArgumentException) {
        MessageBox.Show(@"Произошла ошибка синтаксического анализа регулярного выражения.", @"Ошибка");
      }
      finally {
        Cursor = Cursors.Arrow;
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
      }
    }

    /// <summary>
    /// Выход
    /// </summary>
    private void Quit_Click(object sender, EventArgs e) {
      Close();
    }

    /// <summary>
    /// Вызов формы о программе
    /// </summary>
    private void About_Click(object sender, EventArgs e) {
      var ab = new AboutForm();
      ab.ShowDialog();
    }

    /// <summary>
    /// Открытие папки в проводнике
    /// </summary>
    private void DirectoryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      if (Directory.Exists(_currentForder))
        Process.Start("explorer.exe", _currentForder);
    }
    /// <summary>
    /// Проверка на отсуствие запрещеной комбинации символов
    /// </summary>
    private void SearchBox_Leave(object sender, EventArgs e) {
      if (searchPatternBox.Text.Contains("..")) {
        searchPatternBox.Text = @"*.*";
      }
    }
  }
}