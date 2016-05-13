using System;
using System.Windows.Forms;

namespace BATCH_text_processing {
  static class Program {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new View());
    }
  }
}
