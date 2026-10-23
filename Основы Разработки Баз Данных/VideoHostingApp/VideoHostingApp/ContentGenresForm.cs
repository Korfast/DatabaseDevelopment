using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VideoHostingApp.VideoHostingDBDataSetTableAdapters;

namespace VideoHostingApp
{
    /// <summary>
    /// Форма для проверки требований ЛР3: работа со связью Контент -> Контент_Жанр
    /// и M:M между Контент и Жанр через промежуточную таблицу Контент_Жанр.
    /// </summary>
    public class ContentGenresForm : Form
    {
        private static ContentGenresForm _instance;

        private readonly VideoHostingDBDataSet dataSet = new VideoHostingDBDataSet();
        private readonly КонтентTableAdapter contentTableAdapter = new КонтентTableAdapter();
        private readonly ЖанрTableAdapter genreTableAdapter = new ЖанрTableAdapter();
        private readonly Контент_ЖанрTableAdapter contentGenreTableAdapter = new Контент_ЖанрTableAdapter();

        private readonly BindingSource contentBindingSource = new BindingSource();
        private readonly BindingSource genreBindingSource = new BindingSource();
        private readonly BindingSource contentGenreBindingSource = new BindingSource();

        private readonly BindingNavigator contentBindingNavigator = new BindingNavigator(true);
        private readonly ToolStripTextBox searchTextBox = new ToolStripTextBox();
        private readonly ToolStripButton findButton = new ToolStripButton("Найти");
        private readonly ToolStripButton filterButton = new ToolStripButton("Фильтр");
        private readonly ToolStripButton resetButton = new ToolStripButton("Сброс");
        private readonly ToolStripButton saveButton = new ToolStripButton("Сохранить");

        private readonly DataGridView contentDataGridView = new DataGridView();
        private readonly DataGridView contentGenresDataGridView = new DataGridView();
        private readonly SplitContainer splitContainer = new SplitContainer();
        private readonly Label contentLabel = new Label();
        private readonly Label genresLabel = new Label();

        public static ContentGenresForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ContentGenresForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public ContentGenresForm()
        {
            InitializeForm();
            ConfigureBindings();
        }

        private void InitializeForm()
        {
            Text = "Контент и жанры";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(900, 560);
            Size = new Size(1000, 650);

            contentBindingNavigator.Dock = DockStyle.Top;
            contentBindingNavigator.BindingSource = contentBindingSource;
            contentBindingNavigator.AddNewItem = null;
            contentBindingNavigator.DeleteItem = null;
            contentBindingNavigator.Items.Add(new ToolStripSeparator());
            contentBindingNavigator.Items.Add(new ToolStripLabel("Название:"));
            contentBindingNavigator.Items.Add(searchTextBox);
            contentBindingNavigator.Items.Add(findButton);
            contentBindingNavigator.Items.Add(filterButton);
            contentBindingNavigator.Items.Add(resetButton);
            contentBindingNavigator.Items.Add(new ToolStripSeparator());
            contentBindingNavigator.Items.Add(saveButton);

            // Подсказки для стандартных кнопок навигации
            contentBindingNavigator.MoveFirstItem.ToolTipText = "Первая запись";
            contentBindingNavigator.MovePreviousItem.ToolTipText = "Предыдущая запись";
            contentBindingNavigator.MoveNextItem.ToolTipText = "Следующая запись";
            contentBindingNavigator.MoveLastItem.ToolTipText = "Последняя запись";
            contentBindingNavigator.PositionItem.ToolTipText = "Текущая позиция";
            contentBindingNavigator.CountItem.ToolTipText = "Общее число записей";

            searchTextBox.AutoSize = false;
            searchTextBox.Width = 180;
            searchTextBox.ToolTipText = "Введите часть названия контента";
            findButton.ToolTipText = "Найти первый контент по части названия";
            filterButton.ToolTipText = "Показать только контент с указанной частью названия";
            filterButton.CheckOnClick = true;
            resetButton.ToolTipText = "Сбросить поиск и фильтр";
            saveButton.ToolTipText = "Сохранить связи контента и жанров";

            findButton.Click += FindButton_Click;
            filterButton.CheckedChanged += FilterButton_CheckedChanged;
            resetButton.Click += ResetButton_Click;
            saveButton.Click += SaveButton_Click;
            searchTextBox.KeyDown += SearchTextBox_KeyDown;

            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Orientation = Orientation.Horizontal;
            splitContainer.SplitterDistance = 260;

            contentLabel.Text = "Контент";
            contentLabel.Dock = DockStyle.Top;
            contentLabel.Height = 24;
            contentLabel.TextAlign = ContentAlignment.MiddleLeft;
            contentLabel.Font = new Font(contentLabel.Font, FontStyle.Bold);

            genresLabel.Text = "Жанры выбранного контента";
            genresLabel.Dock = DockStyle.Top;
            genresLabel.Height = 24;
            genresLabel.TextAlign = ContentAlignment.MiddleLeft;
            genresLabel.Font = new Font(genresLabel.Font, FontStyle.Bold);

            ConfigureContentGrid();
            ConfigureContentGenresGrid();

            splitContainer.Panel1.Controls.Add(contentDataGridView);
            splitContainer.Panel1.Controls.Add(contentLabel);
            splitContainer.Panel2.Controls.Add(contentGenresDataGridView);
            splitContainer.Panel2.Controls.Add(genresLabel);

            Controls.Add(splitContainer);
            Controls.Add(contentBindingNavigator);

            Load += ContentGenresForm_Load;
        }

        private void ConfigureContentGrid()
        {
            contentDataGridView.Dock = DockStyle.Fill;
            contentDataGridView.AutoGenerateColumns = false;
            contentDataGridView.AllowUserToAddRows = false;
            contentDataGridView.AllowUserToDeleteRows = false;
            contentDataGridView.ReadOnly = true;
            contentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contentDataGridView.MultiSelect = false;
            contentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contentDataGridView.DataSource = contentBindingSource;

            contentDataGridView.Columns.Add(CreateTextColumn("ID_контента", "ID", 60));
            contentDataGridView.Columns.Add(CreateTextColumn("название", "Название", 220));
            contentDataGridView.Columns.Add(CreateTextColumn("Инфо_контента", "Инфо", 400));
        }

        private void ConfigureContentGenresGrid()
        {
            contentGenresDataGridView.Dock = DockStyle.Fill;
            contentGenresDataGridView.AutoGenerateColumns = false;
            contentGenresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contentGenresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contentGenresDataGridView.DataSource = contentGenreBindingSource;
            contentGenresDataGridView.DataError += ContentGenresDataGridView_DataError;
            contentGenresDataGridView.DefaultValuesNeeded += ContentGenresDataGridView_DefaultValuesNeeded;

            // 1. Подстановка названия контента вместо ID_контента
            DataGridViewTextBoxColumn contentNameColumn =
                CreateTextColumn("Название_контента", "Контент", 260);
            contentNameColumn.ReadOnly = true;
            contentGenresDataGridView.Columns.Add(contentNameColumn);

            // 2. ComboBox для выбора жанра
            DataGridViewComboBoxColumn genreColumn = new DataGridViewComboBoxColumn();
            genreColumn.Name = "ID_жанра";
            genreColumn.DataPropertyName = "ID_жанра";
            genreColumn.HeaderText = "Жанр";
            genreColumn.DataSource = genreBindingSource;
            genreColumn.DisplayMember = "Наименование";
            genreColumn.ValueMember = "ID_жанра";
            genreColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            genreColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            genreColumn.ToolTipText = "Выберите жанр из справочника";
            contentGenresDataGridView.Columns.Add(genreColumn);
        }

        private void ConfigureBindings()
        {
            contentBindingSource.DataSource = dataSet;
            contentBindingSource.DataMember = "Контент";

            genreBindingSource.DataSource = dataSet;
            genreBindingSource.DataMember = "Жанр";

            contentGenreBindingSource.DataSource = contentBindingSource;
            contentGenreBindingSource.DataMember = "FK_Контент_Контент_Жанр";
        }

        private void ContentGenresForm_Load(object sender, EventArgs e)
        {
            try
            {
                //
                EnsureCalculatedColumns();

                //
                contentGenreBindingSource.DataMember = null;
                contentGenreBindingSource.DataMember = "FK_Контент_Контент_Жанр";

                //
                genreTableAdapter.Fill(dataSet.Жанр);
                contentTableAdapter.Fill(dataSet.Контент);
                contentGenreTableAdapter.Fill(dataSet.Контент_Жанр);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке связанных данных:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnsureCalculatedColumns()
        {
            // Верхняя таблица: одно вычисляемое поле со «склейкой» невидимых свойств
            if (!dataSet.Контент.Columns.Contains("Инфо_контента"))
            {
                DataColumn infoColumn = new DataColumn("Инфо_контента", typeof(string));
                infoColumn.Expression =
                    "оригинальное_название + ' / ' + тип_контента + ' / ' + " +
                    "Convert(год_выпуска, 'System.String') + ' / ' + страна_производства";
                dataSet.Контент.Columns.Add(infoColumn);
            }

            // Нижняя таблица: подстановка названия контента вместо ID
            if (!dataSet.Контент_Жанр.Columns.Contains("Название_контента"))
            {
                DataColumn contentLookupColumn = new DataColumn("Название_контента", typeof(string));
                contentLookupColumn.Expression = "Parent(FK_Контент_Контент_Жанр).название";
                dataSet.Контент_Жанр.Columns.Add(contentLookupColumn);
            }
        }

        private DataGridViewTextBoxColumn CreateTextColumn(string propertyName, string headerText, int width)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = propertyName;
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            return column;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filterButton.Checked)
                    ApplyFilter();
                else
                    FindContent();
                e.SuppressKeyPress = true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindContent();
        }

        private void FilterButton_CheckedChanged(object sender, EventArgs e)
        {
            if (filterButton.Checked)
                ApplyFilter();
            else
                contentBindingSource.RemoveFilter();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            filterButton.Checked = false;
            contentBindingSource.RemoveFilter();
        }

        private void FindContent()
        {
            string searchText = searchTextBox.Text.Trim();
            if (searchText.Length == 0)
            {
                MessageBox.Show("Введите часть названия контента.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < contentBindingSource.Count; i++)
            {
                DataRowView row = contentBindingSource[i] as DataRowView;
                string title = Convert.ToString(row["название"]);
                if (title.IndexOf(searchText, StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    contentBindingSource.Position = i;
                    return;
                }
            }

            MessageBox.Show("Контент с таким названием не найден.", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyFilter()
        {
            string searchText = searchTextBox.Text.Trim();
            if (searchText.Length == 0)
            {
                MessageBox.Show("Введите часть названия контента.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                filterButton.Checked = false;
                return;
            }

            try
            {
                contentBindingSource.Filter = "Convert([название], 'System.String') LIKE '%" + EscapeFilterValue(searchText) + "%'";
            }
            catch (Exception ex)
            {
                contentBindingSource.RemoveFilter();
                filterButton.Checked = false;
                MessageBox.Show("Ошибка фильтрации контента:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeFilterValue(string value)
        {
            return value
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");
        }

        private void ContentGenresDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // ID_контента специально не показывается в нижней таблице:
            // внешний ключ устанавливается самой связью мастер–деталь.
            if (genreBindingSource.Count > 0)
            {
                DataRowView firstGenre = genreBindingSource[0] as DataRowView;
                e.Row.Cells["ID_жанра"].Value = firstGenre["ID_жанра"];
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                contentGenreBindingSource.EndEdit();
                contentBindingSource.EndEdit();
                contentGenreTableAdapter.Update(dataSet.Контент_Жанр);
                MessageBox.Show("Связи контента и жанров сохранены.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении связей контента и жанров:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContentGenresDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Ошибка в связанных данных. Проверьте, что выбран существующий жанр и связь не дублируется.",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
