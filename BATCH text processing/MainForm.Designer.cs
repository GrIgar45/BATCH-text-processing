namespace BATCH_text_processing {
  partial class MainForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileTools = new System.Windows.Forms.ToolStripMenuItem();
      this.choseDirectory = new System.Windows.Forms.ToolStripMenuItem();
      this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.referenceMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.checkView = new System.Windows.Forms.ListView();
      this.regexPanel = new System.Windows.Forms.Panel();
      this.centerContainer = new System.Windows.Forms.SplitContainer();
      this.findTextBox = new System.Windows.Forms.GroupBox();
      this.searchBox = new System.Windows.Forms.TextBox();
      this.replaseTextBox = new System.Windows.Forms.GroupBox();
      this.replaceBox = new System.Windows.Forms.TextBox();
      this.controlPanel = new System.Windows.Forms.Panel();
      this.paternLabel = new System.Windows.Forms.Label();
      this.searchPatternBox = new System.Windows.Forms.TextBox();
      this.refreshButton = new System.Windows.Forms.Button();
      this.replaceButton = new System.Windows.Forms.Button();
      this.searchButton = new System.Windows.Forms.Button();
      this.directoryPath = new System.Windows.Forms.TextBox();
      this.folderLink = new System.Windows.Forms.LinkLabel();
      this.openDirectoryButton = new System.Windows.Forms.Button();
      this.leftContainer = new System.Windows.Forms.SplitContainer();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.menuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.regexPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).BeginInit();
      this.centerContainer.Panel1.SuspendLayout();
      this.centerContainer.Panel2.SuspendLayout();
      this.centerContainer.SuspendLayout();
      this.findTextBox.SuspendLayout();
      this.replaseTextBox.SuspendLayout();
      this.controlPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
      this.leftContainer.Panel1.SuspendLayout();
      this.leftContainer.Panel2.SuspendLayout();
      this.leftContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTools,
            this.referenceMenu});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(734, 24);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuStrip1";
      // 
      // fileTools
      // 
      this.fileTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choseDirectory,
            this.quitButton});
      this.fileTools.Name = "fileTools";
      this.fileTools.Size = new System.Drawing.Size(48, 20);
      this.fileTools.Text = "Файл";
      // 
      // choseDirectory
      // 
      this.choseDirectory.Name = "choseDirectory";
      this.choseDirectory.Size = new System.Drawing.Size(192, 22);
      this.choseDirectory.Text = "Выбрать директорию";
      this.choseDirectory.Click += new System.EventHandler(this.ChoseDirectory_Click);
      // 
      // quitButton
      // 
      this.quitButton.Name = "quitButton";
      this.quitButton.Size = new System.Drawing.Size(192, 22);
      this.quitButton.Text = "Выход";
      this.quitButton.Click += new System.EventHandler(this.Quit_Click);
      // 
      // referenceMenu
      // 
      this.referenceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
      this.referenceMenu.Name = "referenceMenu";
      this.referenceMenu.Size = new System.Drawing.Size(65, 20);
      this.referenceMenu.Text = "Справка";
      // 
      // aboutButton
      // 
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Size = new System.Drawing.Size(152, 22);
      this.aboutButton.Text = "О рограмме";
      this.aboutButton.Click += new System.EventHandler(this.About_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 414);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(734, 22);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "statusStrip1";
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
      // regexPanel
      // 
      this.regexPanel.Controls.Add(this.centerContainer);
      this.regexPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.regexPanel.Location = new System.Drawing.Point(0, 0);
      this.regexPanel.Name = "regexPanel";
      this.regexPanel.Size = new System.Drawing.Size(263, 390);
      this.regexPanel.TabIndex = 4;
      // 
      // centerContainer
      // 
      this.centerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.centerContainer.Location = new System.Drawing.Point(0, 0);
      this.centerContainer.Name = "centerContainer";
      this.centerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // centerContainer.Panel1
      // 
      this.centerContainer.Panel1.Controls.Add(this.findTextBox);
      // 
      // centerContainer.Panel2
      // 
      this.centerContainer.Panel2.Controls.Add(this.replaseTextBox);
      this.centerContainer.Size = new System.Drawing.Size(263, 390);
      this.centerContainer.SplitterDistance = 179;
      this.centerContainer.TabIndex = 0;
      this.centerContainer.TabStop = false;
      // 
      // findTextBox
      // 
      this.findTextBox.Controls.Add(this.searchBox);
      this.findTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.findTextBox.Location = new System.Drawing.Point(0, 0);
      this.findTextBox.Name = "findTextBox";
      this.findTextBox.Size = new System.Drawing.Size(263, 179);
      this.findTextBox.TabIndex = 2;
      this.findTextBox.TabStop = false;
      this.findTextBox.Text = "Искомый текст";
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
      // replaseTextBox
      // 
      this.replaseTextBox.Controls.Add(this.replaceBox);
      this.replaseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.replaseTextBox.Location = new System.Drawing.Point(0, 0);
      this.replaseTextBox.Name = "replaseTextBox";
      this.replaseTextBox.Size = new System.Drawing.Size(263, 207);
      this.replaseTextBox.TabIndex = 3;
      this.replaseTextBox.TabStop = false;
      this.replaseTextBox.Text = "Заменяемый текст";
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
      // controlPanel
      // 
      this.controlPanel.Controls.Add(this.paternLabel);
      this.controlPanel.Controls.Add(this.searchPatternBox);
      this.controlPanel.Controls.Add(this.refreshButton);
      this.controlPanel.Controls.Add(this.replaceButton);
      this.controlPanel.Controls.Add(this.searchButton);
      this.controlPanel.Controls.Add(this.directoryPath);
      this.controlPanel.Controls.Add(this.folderLink);
      this.controlPanel.Controls.Add(this.openDirectoryButton);
      this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPanel.Location = new System.Drawing.Point(0, 0);
      this.controlPanel.Name = "controlPanel";
      this.controlPanel.Size = new System.Drawing.Size(163, 390);
      this.controlPanel.TabIndex = 5;
      // 
      // paternLabel
      // 
      this.paternLabel.AutoSize = true;
      this.paternLabel.Location = new System.Drawing.Point(12, 54);
      this.paternLabel.Name = "paternLabel";
      this.paternLabel.Size = new System.Drawing.Size(81, 13);
      this.paternLabel.TabIndex = 9;
      this.paternLabel.Text = "Маска файлов";
      // 
      // searchPatternBox
      // 
      this.searchPatternBox.Location = new System.Drawing.Point(3, 70);
      this.searchPatternBox.Name = "searchPatternBox";
      this.searchPatternBox.Size = new System.Drawing.Size(154, 20);
      this.searchPatternBox.TabIndex = 8;
      this.searchPatternBox.TabStop = false;
      this.searchPatternBox.Text = "*.*";
      this.searchPatternBox.Leave += new System.EventHandler(this.SearchBox_Leave);
      // 
      // refreshButton
      // 
      this.refreshButton.Enabled = false;
      this.refreshButton.Location = new System.Drawing.Point(84, 96);
      this.refreshButton.Name = "refreshButton";
      this.refreshButton.Size = new System.Drawing.Size(70, 23);
      this.refreshButton.TabIndex = 7;
      this.refreshButton.TabStop = false;
      this.refreshButton.Text = "Обновить";
      this.refreshButton.UseVisualStyleBackColor = true;
      this.refreshButton.Click += new System.EventHandler(this.Refresh_Click);
      // 
      // replaceButton
      // 
      this.replaceButton.Enabled = false;
      this.replaceButton.Location = new System.Drawing.Point(3, 125);
      this.replaceButton.Name = "replaceButton";
      this.replaceButton.Size = new System.Drawing.Size(151, 23);
      this.replaceButton.TabIndex = 6;
      this.replaceButton.TabStop = false;
      this.replaceButton.Text = "Поиск и замена";
      this.replaceButton.UseVisualStyleBackColor = true;
      this.replaceButton.Click += new System.EventHandler(this.Replace_Click);
      // 
      // searchButton
      // 
      this.searchButton.Enabled = false;
      this.searchButton.Location = new System.Drawing.Point(3, 96);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(70, 23);
      this.searchButton.TabIndex = 5;
      this.searchButton.TabStop = false;
      this.searchButton.Text = "Поиск";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.Search_Click);
      // 
      // directoryPath
      // 
      this.directoryPath.Location = new System.Drawing.Point(3, 22);
      this.directoryPath.Name = "directoryPath";
      this.directoryPath.Size = new System.Drawing.Size(124, 20);
      this.directoryPath.TabIndex = 2;
      this.directoryPath.TabStop = false;
      this.directoryPath.Leave += new System.EventHandler(this.LeaveDirectoryPath);
      // 
      // folderLink
      // 
      this.folderLink.AutoSize = true;
      this.folderLink.Location = new System.Drawing.Point(12, 6);
      this.folderLink.Name = "folderLink";
      this.folderLink.Size = new System.Drawing.Size(48, 13);
      this.folderLink.TabIndex = 1;
      this.folderLink.TabStop = true;
      this.folderLink.Text = "Каталог";
      this.folderLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DirectoryLinkClicked);
      // 
      // openDirectoryButton
      // 
      this.openDirectoryButton.Location = new System.Drawing.Point(133, 22);
      this.openDirectoryButton.Name = "openDirectoryButton";
      this.openDirectoryButton.Size = new System.Drawing.Size(24, 20);
      this.openDirectoryButton.TabIndex = 0;
      this.openDirectoryButton.TabStop = false;
      this.openDirectoryButton.Text = "...";
      this.openDirectoryButton.UseVisualStyleBackColor = true;
      this.openDirectoryButton.Click += new System.EventHandler(this.ChoseDirectory_Click);
      // 
      // leftContainer
      // 
      this.leftContainer.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.leftContainer.Location = new System.Drawing.Point(0, 24);
      this.leftContainer.Name = "leftContainer";
      // 
      // leftContainer.Panel1
      // 
      this.leftContainer.Panel1.Controls.Add(this.controlPanel);
      // 
      // leftContainer.Panel2
      // 
      this.leftContainer.Panel2.Controls.Add(this.regexPanel);
      this.leftContainer.Size = new System.Drawing.Size(430, 390);
      this.leftContainer.SplitterDistance = 163;
      this.leftContainer.TabIndex = 8;
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
      this.errorProvider.ContainerControl = this;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 436);
      this.Controls.Add(this.checkView);
      this.Controls.Add(this.leftContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.MinimumSize = new System.Drawing.Size(750, 400);
      this.Name = "MainForm";
      this.Text = "KURS text2text";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.regexPanel.ResumeLayout(false);
      this.centerContainer.Panel1.ResumeLayout(false);
      this.centerContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).EndInit();
      this.centerContainer.ResumeLayout(false);
      this.findTextBox.ResumeLayout(false);
      this.findTextBox.PerformLayout();
      this.replaseTextBox.ResumeLayout(false);
      this.replaseTextBox.PerformLayout();
      this.controlPanel.ResumeLayout(false);
      this.controlPanel.PerformLayout();
      this.leftContainer.Panel1.ResumeLayout(false);
      this.leftContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
      this.leftContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileTools;
    private System.Windows.Forms.ToolStripMenuItem choseDirectory;
    private System.Windows.Forms.ToolStripMenuItem quitButton;
    private System.Windows.Forms.ToolStripMenuItem referenceMenu;
    private System.Windows.Forms.ToolStripMenuItem aboutButton;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.ListView checkView;
    private System.Windows.Forms.Panel regexPanel;
    private System.Windows.Forms.SplitContainer centerContainer;
    private System.Windows.Forms.GroupBox findTextBox;
    private System.Windows.Forms.TextBox searchBox;
    private System.Windows.Forms.GroupBox replaseTextBox;
    private System.Windows.Forms.TextBox replaceBox;
    private System.Windows.Forms.Panel controlPanel;
    private System.Windows.Forms.Button replaceButton;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox directoryPath;
    private System.Windows.Forms.LinkLabel folderLink;
    private System.Windows.Forms.Button openDirectoryButton;
    private System.Windows.Forms.SplitContainer leftContainer;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.Button refreshButton;
    private System.Windows.Forms.TextBox searchPatternBox;
    private System.Windows.Forms.Label paternLabel;
  }
}

