using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BATCH_text_processing {
  public partial class View {
    /// <summary>
    /// Нажатие кнопки выпора директории
    /// </summary>
    private void ChoseDirectory_Click(object sender, EventArgs e) {
      var openDialog = new FolderBrowserDialog { ShowNewFolderButton = false };
      if (openDialog.ShowDialog() != DialogResult.OK) return;
      if (!CheckDirectiryExist(openDialog.SelectedPath)) return;
      _currentForder = openDialog.SelectedPath;
      statusLabel.Text = openDialog.SelectedPath;
      directoryPath.Text = openDialog.SelectedPath;
      RemoveDirectiryPathError();
      GetAllFilePath();
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
      GetAllFilePath();
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
      errorProvider1.SetError(this.directoryPath, error);
    }
    private void RemoveDirectiryPathError() {
      replace.Enabled = true;
      search.Enabled = true;
      errorProvider1.SetError(this.directoryPath, string.Empty);
    }

    /// <summary>
    /// Получить адресса всех файлов
    /// </summary>
    public void GetAllFilePath() {
      try {
        _pathList = new List<string>();
        _fileDirectory = new FileDirectory(_currentForder, ref _pathList);
        FillListOfFile();
      }
      catch (UnauthorizedAccessException e) {
        SetDirectiryPathError("Ошибка доступа");
      }
    }

    /// <summary>
    /// Заполнение списка файлов
    /// </summary>
    private void FillListOfFile() {
      checkView.Clear();
      foreach (var path in _pathList) {
        checkView.Items.Add(path);
      }
    }
  }
}
