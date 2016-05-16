namespace BATCH_text_processing {
  partial class View {
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
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileTools = new System.Windows.Forms.ToolStripMenuItem();
      this.ChoseDirectory = new System.Windows.Forms.ToolStripMenuItem();
      this.quit = new System.Windows.Forms.ToolStripMenuItem();
      this.reference = new System.Windows.Forms.ToolStripMenuItem();
      this.about = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.checkView = new System.Windows.Forms.ListView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.searchBox = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.replaceBox = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.refresh = new System.Windows.Forms.Button();
      this.replace = new System.Windows.Forms.Button();
      this.search = new System.Windows.Forms.Button();
      this.directoryPath = new System.Windows.Forms.TextBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.button1 = new System.Windows.Forms.Button();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTools,
            this.reference});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(734, 24);
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
      this.quit.Click += new System.EventHandler(this.quit_Click);
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
      this.about.Click += new System.EventHandler(this.about_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 414);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(734, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(189, 17);
      this.statusLabel.Text = "Текущая директория не выбрана";
      // 
      // checkView
      // 
      this.checkView.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.checkView.CheckBoxes = true;
      this.checkView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.checkView.Location = new System.Drawing.Point(430, 24);
      this.checkView.Name = "checkView";
      this.checkView.Size = new System.Drawing.Size(304, 390);
      this.checkView.TabIndex = 10;
      this.checkView.TabStop = false;
      this.checkView.UseCompatibleStateImageBehavior = false;
      this.checkView.View = System.Windows.Forms.View.List;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.splitContainer1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(263, 390);
      this.panel1.TabIndex = 4;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
      this.splitContainer1.Size = new System.Drawing.Size(263, 390);
      this.splitContainer1.SplitterDistance = 179;
      this.splitContainer1.TabIndex = 0;
      this.splitContainer1.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.searchBox);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(263, 179);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Искомый текст";
      // 
      // searchBox
      // 
      this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchBox.Location = new System.Drawing.Point(3, 16);
      this.searchBox.Multiline = true;
      this.searchBox.Name = "searchBox";
      this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.searchBox.Size = new System.Drawing.Size(257, 160);
      this.searchBox.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.replaceBox);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(263, 207);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Заменяемый текст";
      // 
      // replaceBox
      // 
      this.replaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.replaceBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.replaceBox.Location = new System.Drawing.Point(3, 16);
      this.replaceBox.Multiline = true;
      this.replaceBox.Name = "replaceBox";
      this.replaceBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.replaceBox.Size = new System.Drawing.Size(257, 188);
      this.replaceBox.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.refresh);
      this.panel2.Controls.Add(this.replace);
      this.panel2.Controls.Add(this.search);
      this.panel2.Controls.Add(this.directoryPath);
      this.panel2.Controls.Add(this.linkLabel1);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(163, 390);
      this.panel2.TabIndex = 5;
      // 
      // refresh
      // 
      this.refresh.Enabled = false;
      this.refresh.Location = new System.Drawing.Point(87, 48);
      this.refresh.Name = "refresh";
      this.refresh.Size = new System.Drawing.Size(70, 23);
      this.refresh.TabIndex = 7;
      this.refresh.TabStop = false;
      this.refresh.Text = "Обновить";
      this.refresh.UseVisualStyleBackColor = true;
      this.refresh.Click += new System.EventHandler(this.Refresh_Click);
      // 
      // replace
      // 
      this.replace.Enabled = false;
      this.replace.Location = new System.Drawing.Point(6, 77);
      this.replace.Name = "replace";
      this.replace.Size = new System.Drawing.Size(151, 23);
      this.replace.TabIndex = 6;
      this.replace.TabStop = false;
      this.replace.Text = "Поиск и замена";
      this.replace.UseVisualStyleBackColor = true;
      this.replace.Click += new System.EventHandler(this.replace_Click);
      // 
      // search
      // 
      this.search.Enabled = false;
      this.search.Location = new System.Drawing.Point(6, 48);
      this.search.Name = "search";
      this.search.Size = new System.Drawing.Size(70, 23);
      this.search.TabIndex = 5;
      this.search.TabStop = false;
      this.search.Text = "Поиск";
      this.search.UseVisualStyleBackColor = true;
      this.search.Click += new System.EventHandler(this.search_Click);
      // 
      // directoryPath
      // 
      this.directoryPath.Location = new System.Drawing.Point(3, 22);
      this.directoryPath.Name = "directoryPath";
      this.directoryPath.Size = new System.Drawing.Size(127, 20);
      this.directoryPath.TabIndex = 2;
      this.directoryPath.TabStop = false;
      this.directoryPath.Leave += new System.EventHandler(this.LeaveDirectoryPath);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(12, 6);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(48, 13);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Каталог";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(133, 22);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(24, 20);
      this.button1.TabIndex = 0;
      this.button1.TabStop = false;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.ChoseDirectory_Click);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
      this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer2.Location = new System.Drawing.Point(0, 24);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.panel2);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.panel1);
      this.splitContainer2.Size = new System.Drawing.Size(430, 390);
      this.splitContainer2.SplitterDistance = 163;
      this.splitContainer2.TabIndex = 8;
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // View
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 436);
      this.Controls.Add(this.checkView);
      this.Controls.Add(this.splitContainer2);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(750, 400);
      this.Name = "View";
      this.Text = "BATCH processing";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileTools;
    private System.Windows.Forms.ToolStripMenuItem ChoseDirectory;
    private System.Windows.Forms.ToolStripMenuItem quit;
    private System.Windows.Forms.ToolStripMenuItem reference;
    private System.Windows.Forms.ToolStripMenuItem about;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.ListView checkView;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox searchBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox replaceBox;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button replace;
    private System.Windows.Forms.Button search;
    private System.Windows.Forms.TextBox directoryPath;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button refresh;
  }
}

