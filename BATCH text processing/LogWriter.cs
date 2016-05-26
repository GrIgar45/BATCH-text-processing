using System;
using System.IO;
using System.Text;

namespace BATCH_text_processing {
  internal class LogWriter {
    private readonly StringBuilder _stringBuilder;

    public LogWriter(string path, string logType) {
      _stringBuilder = new StringBuilder();
      _stringBuilder.Append($"{DateTime.Now}: Каталог: {path} - {logType}{Environment.NewLine}");
    }
    /// <summary>
    /// Добавляет логи в буфер
    /// </summary>
    /// <param name="file">Адрес</param>
    /// <param name="result">Результат</param>
    public void AddLog(string file, string result) {
      _stringBuilder.Append($"{DateTime.Now.ToLongTimeString()}: {result}{Environment.NewLine}{file}{Environment.NewLine}");
    }
    /// <summary>
    /// Записывает логи в буфере
    /// </summary>
    public void LogWrite() {
      File.WriteAllText($"log{DateTime.Now:yyyy-MM-dd_hh-mm-ss}.txt", _stringBuilder.ToString());
    }
  }
}
