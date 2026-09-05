namespace VideoHostingApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightHoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(884, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.rightHoldersToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.licensesToolStripMenuItem,
            this.contractsToolStripMenuItem,
            this.mediaFilesToolStripMenuItem});
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.referencesToolStripMenuItem.Text = "Справочники";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contentToolStripMenuItem.Text = "Контент";
            this.contentToolStripMenuItem.Click += new System.EventHandler(this.ContentToolStripMenuItem_Click);
            // 
            // rightHoldersToolStripMenuItem
            // 
            this.rightHoldersToolStripMenuItem.Name = "rightHoldersToolStripMenuItem";
            this.rightHoldersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightHoldersToolStripMenuItem.Text = "Правообладатели";
            this.rightHoldersToolStripMenuItem.Click += new System.EventHandler(this.RightHoldersToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem.Text = "Жанры";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.GenresToolStripMenuItem_Click);
            // 
            // licensesToolStripMenuItem
            // 
            this.licensesToolStripMenuItem.Name = "licensesToolStripMenuItem";
            this.licensesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licensesToolStripMenuItem.Text = "Лицензии";
            this.licensesToolStripMenuItem.Click += new System.EventHandler(this.LicensesToolStripMenuItem_Click);
            // 
            // contractsToolStripMenuItem
            // 
            this.contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            this.contractsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contractsToolStripMenuItem.Text = "Договоры";
            this.contractsToolStripMenuItem.Click += new System.EventHandler(this.ContractsToolStripMenuItem_Click);
            // 
            // mediaFilesToolStripMenuItem
            // 
            this.mediaFilesToolStripMenuItem.Name = "mediaFilesToolStripMenuItem";
            this.mediaFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediaFilesToolStripMenuItem.Text = "Медиафайлы";
            this.mediaFilesToolStripMenuItem.Click += new System.EventHandler(this.MediaFilesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Управление контентом видеохостинга";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightHoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

