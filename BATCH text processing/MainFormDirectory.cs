using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class MainForm {
    /// <summary>
    /// Нажатие кнопки выпора директории
    /// </summary>
    private void ChoseDirectory_Click(object sender, EventArgs e) {
      var openDialog = new FolderBrowserDialog {ShowNewFolderButton = false};
      if (openDialog.ShowDialog() != DialogResult.OK || !CheckDirectiryExist(openDialog.SelectedPath)) return;
      _currentForder = openDialog.SelectedPath;
      statusLabel.Text = openDialog.SelectedPath;
      directoryPath.Text = openDialog.SelectedPath;
      Cursor = Cursors.WaitCursor;
      RemoveDirectiryPathError();
      GetAllFilePath();
      Cursor = Cursors.Arrow;
    }
    
    /// <summary>
    /// Обработка нажатия клавиши обновить
    /// </summary>
    private void Refresh_Click(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      RemoveDirectiryPathError();
      GetAllFilePath();
      Cursor = Cursors.Arrow;
    }

    /// <summary>
    /// Потеря фокуса адреса пути директории
    /// </summary>
    private void LeaveDirectoryPath(object sender, EventArgs e) {
      if (!CheckDirectiryExist(directoryPath.Text)) {
        SetDirectiryPathError("Директория не найдена");
        statusLabel.Text = @"Текущая директория не выбрана";
        return;
      }
      RemoveDirectiryPathError();
      statusLabel.Text = directoryPath.Text;
      _currentForder = directoryPath.Text;
      Cursor = Cursors.WaitCursor;
      GetAllFilePath();
      Cursor = Cursors.Arrow;
    }

    /// <summary>
    /// Проверка, коректен ли адресс пути
    /// Если нет, показывается соотвествующее сообщение
    /// </summary>
    /// <param name="path">Путь к директории</param>
    /// <returns>Коректность адресса</returns>
    private static bool CheckDirectiryExist(string path) {
      if (Directory.Exists(path)) return true;
      MessageBox.Show(@"Выбраная директория не существует");
      return false;
    }

    private void SetDirectiryPathError(string error) {
      replace.Enabled = false;
      search.Enabled = false;
      refresh.Enabled = false;
      errorProvider.SetError(this.directoryPath, error);
    }
    private void RemoveDirectiryPathError() {
      replace.Enabled = true;
      search.Enabled = true;
      refresh.Enabled = true;
      errorProvider.SetError(this.directoryPath, string.Empty);
    }

    /// <summary>
    /// Получить адресса всех файлов
    /// </summary>
    public void GetAllFilePath() {
      try {
        _pathList = new List<string>();
        FileDirectory.FilesCount = 0;
        _fileDirectory = new FileDirectory(_currentForder, ref _pathList, searchPatternBox.Text);
        FillListOfFile();
      }
      catch (UnauthorizedAccessException) {
        SetDirectiryPathError("Ошибка доступа");
      }
    }

    /// <summary>
    /// Заполнение списка файлов
    /// </summary>
    private void FillListOfFile() {
      checkView.Clear();
      for (var index = 0; index < _pathList.Count; index++) {
        checkView.Items.Add(_pathList[index]);
        checkView.Items[index].Checked = true;
      }
    }
  }
}
