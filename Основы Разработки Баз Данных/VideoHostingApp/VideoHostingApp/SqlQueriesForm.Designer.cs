namespace VideoHostingApp
{
    partial class SqlQueriesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.operationLabel = new System.Windows.Forms.Label();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.executeSelectButton = new System.Windows.Forms.Button();
            this.parametersGroupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.originalNameLabel = new System.Windows.Forms.Label();
            this.originalNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.parametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // operationLabel
            //
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(12, 15);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(47, 13);
            this.operationLabel.TabIndex = 0;
            this.operationLabel.Text = "Режим:";
            //
            // operationComboBox
            //
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.operationComboBox.Location = new System.Drawing.Point(75, 12);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(105, 21);
            this.operationComboBox.TabIndex = 1;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.OperationComboBox_SelectedIndexChanged);
            //
            // queryLabel
            //
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(195, 15);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(47, 13);
            this.queryLabel.TabIndex = 2;
            this.queryLabel.Text = "Запрос:";
            //
            // queryComboBox
            //
            this.queryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            "1. Выборка контента",
            "2. Поиск по названию",
            "3. Контент и жанры (JOIN)",
            "4. Группировка по странам (с указанного года)",
            "5. Агрегатные функции",
            "6. Подзапрос IN",
            "7. Подзапрос EXISTS",
            "8. Скалярный подзапрос"});
            this.queryComboBox.Location = new System.Drawing.Point(258, 12);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(300, 21);
            this.queryComboBox.TabIndex = 3;
            this.queryComboBox.SelectedIndexChanged += new System.EventHandler(this.QueryComboBox_SelectedIndexChanged);
            //
            // executeSelectButton
            //
            this.executeSelectButton.Location = new System.Drawing.Point(570, 10);
            this.executeSelectButton.Name = "executeSelectButton";
            this.executeSelectButton.Size = new System.Drawing.Size(145, 25);
            this.executeSelectButton.TabIndex = 4;
            this.executeSelectButton.Text = "Выполнить SELECT";
            this.executeSelectButton.UseVisualStyleBackColor = true;
            this.executeSelectButton.Click += new System.EventHandler(this.ExecuteSelectButton_Click);
            //
            // parametersGroupBox
            //
            this.parametersGroupBox.Controls.Add(this.idLabel);
            this.parametersGroupBox.Controls.Add(this.idTextBox);
            this.parametersGroupBox.Controls.Add(this.dateLabel);
            this.parametersGroupBox.Controls.Add(this.datePicker);
            this.parametersGroupBox.Controls.Add(this.countryLabel);
            this.parametersGroupBox.Controls.Add(this.countryTextBox);
            this.parametersGroupBox.Controls.Add(this.typeLabel);
            this.parametersGroupBox.Controls.Add(this.typeTextBox);
            this.parametersGroupBox.Controls.Add(this.yearLabel);
            this.parametersGroupBox.Controls.Add(this.yearTextBox);
            this.parametersGroupBox.Controls.Add(this.originalNameLabel);
            this.parametersGroupBox.Controls.Add(this.originalNameTextBox);
            this.parametersGroupBox.Controls.Add(this.nameLabel);
            this.parametersGroupBox.Controls.Add(this.nameTextBox);
            this.parametersGroupBox.Location = new System.Drawing.Point(12, 45);
            this.parametersGroupBox.Name = "parametersGroupBox";
            this.parametersGroupBox.Size = new System.Drawing.Size(523, 130);
            this.parametersGroupBox.TabIndex = 3;
            this.parametersGroupBox.TabStop = false;
            this.parametersGroupBox.Text = "Параметры запросов";
            //
            // idLabel
            //
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(272, 108);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "ID:";
            //
            // idTextBox
            //
            this.idTextBox.Location = new System.Drawing.Point(314, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(135, 20);
            this.idTextBox.TabIndex = 15;
            //
            // dateLabel
            //
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(272, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Дата:";
            //
            // datePicker
            //
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(314, 78);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(135, 20);
            this.datePicker.TabIndex = 13;
            //
            // countryLabel
            //
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(272, 53);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Страна:";
            //
            // countryTextBox
            //
            this.countryTextBox.Location = new System.Drawing.Point(314, 50);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(135, 20);
            this.countryTextBox.TabIndex = 11;
            //
            // typeLabel
            //
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(272, 25);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(78, 13);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Тип контента:";
            //
            // typeTextBox
            //
            this.typeTextBox.Location = new System.Drawing.Point(354, 22);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(95, 20);
            this.typeTextBox.TabIndex = 9;
            this.typeTextBox.Text = "Фильм";
            //
            // yearLabel
            //
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(9, 82);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(28, 13);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Год:";
            //
            // yearTextBox
            //
            this.yearTextBox.Location = new System.Drawing.Point(82, 78);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(130, 20);
            this.yearTextBox.TabIndex = 7;
            this.yearTextBox.Text = "1900";
            //
            // originalNameLabel
            //
            this.originalNameLabel.AutoSize = true;
            this.originalNameLabel.Location = new System.Drawing.Point(9, 53);
            this.originalNameLabel.Name = "originalNameLabel";
            this.originalNameLabel.Size = new System.Drawing.Size(59, 13);
            this.originalNameLabel.TabIndex = 4;
            this.originalNameLabel.Text = "Оригинал:";
            //
            // originalNameTextBox
            //
            this.originalNameTextBox.Location = new System.Drawing.Point(82, 50);
            this.originalNameTextBox.Name = "originalNameTextBox";
            this.originalNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.originalNameTextBox.TabIndex = 5;
            //
            // nameLabel
            //
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название:";
            //
            // nameTextBox
            //
            this.nameTextBox.Location = new System.Drawing.Point(82, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 1;
            //
            // insertButton
            //
            this.insertButton.Location = new System.Drawing.Point(550, 50);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(130, 28);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Выполнить INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.OperationButton_Click);
            //
            // updateButton
            //
            this.updateButton.Location = new System.Drawing.Point(550, 84);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "UPDATE / Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            //
            // deleteButton
            //
            this.deleteButton.Location = new System.Drawing.Point(550, 118);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 28);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "DELETE / Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            //
            // resultDataGridView
            //
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(12, 190);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGridView.Size = new System.Drawing.Size(824, 321);
            this.resultDataGridView.TabIndex = 7;
            //
            // statusLabel
            //
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 521);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusLabel.Size = new System.Drawing.Size(848, 40);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Статус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // SqlQueriesForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 561);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.parametersGroupBox);
            this.Controls.Add(this.executeSelectButton);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.operationLabel);
            this.MinimumSize = new System.Drawing.Size(864, 600);
            this.Name = "SqlQueriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL-запросы";
            this.parametersGroupBox.ResumeLayout(false);
            this.parametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Button executeSelectButton;
        private System.Windows.Forms.GroupBox parametersGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label originalNameLabel;
        private System.Windows.Forms.TextBox originalNameTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Label statusLabel;
    }
}
