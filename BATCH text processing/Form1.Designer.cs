namespace BATCH_text_processing {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileTools = new System.Windows.Forms.ToolStripMenuItem();
      this.ChoseDirectory = new System.Windows.Forms.ToolStripMenuItem();
      this.quit = new System.Windows.Forms.ToolStripMenuItem();
      this.reference = new System.Windows.Forms.ToolStripMenuItem();
      this.about = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.panel1 = new System.Windows.Forms.Panel();
      this.replace = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
      this.splitContainer1.Size = new System.Drawing.Size(494, 381);
      this.splitContainer1.SplitterDistance = 241;
      this.splitContainer1.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 16);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(235, 362);
      this.textBox1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(241, 381);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Исходный текст";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox2);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(249, 381);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Заменяемый текст";
      // 
      // textBox2
      // 
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Location = new System.Drawing.Point(3, 16);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox2.Size = new System.Drawing.Size(243, 362);
      this.textBox2.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTools,
            this.replace,
            this.reference});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(494, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileTools
      // 
      this.fileTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChoseDirectory,
            this.quit});
      this.fileTools.Name = "fileTools";
      this.fileTools.Size = new System.Drawing.Size(48, 20);
      this.fileTools.Text = "Файл";
      // 
      // ChoseDirectory
      // 
      this.ChoseDirectory.Name = "ChoseDirectory";
      this.ChoseDirectory.Size = new System.Drawing.Size(192, 22);
      this.ChoseDirectory.Text = "Выбрать директорию";
      this.ChoseDirectory.Click += new System.EventHandler(this.ChoseDirectory_Click);
      // 
      // quit
      // 
      this.quit.Name = "quit";
      this.quit.Size = new System.Drawing.Size(192, 22);
      this.quit.Text = "Выход";
      // 
      // reference
      // 
      this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
      this.reference.Name = "reference";
      this.reference.Size = new System.Drawing.Size(65, 20);
      this.reference.Text = "Справка";
      // 
      // about
      // 
      this.about.Name = "about";
      this.about.Size = new System.Drawing.Size(152, 22);
      this.about.Text = "О рограмме";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 408);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(494, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(118, 17);
      this.statusLabel.Text = "toolStripStatusLabel1";
      // 
      // splitter1
      // 
      this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 405);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(494, 3);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.splitContainer1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(494, 381);
      this.panel1.TabIndex = 4;
      // 
      // replace
      // 
      this.replace.Name = "replace";
      this.replace.Size = new System.Drawing.Size(123, 20);
      this.replace.Text = "Выполнить замену";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(494, 430);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "BATCH";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileTools;
    private System.Windows.Forms.ToolStripMenuItem ChoseDirectory;
    private System.Windows.Forms.ToolStripMenuItem quit;
    private System.Windows.Forms.ToolStripMenuItem reference;
    private System.Windows.Forms.ToolStripMenuItem about;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolStripMenuItem replace;
  }
}

