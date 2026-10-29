using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace VideoHostingApp
{
    /// <summary>
    /// Форма для выполнения запросов лабораторной работы №4.
    /// SELECT-запросы выводятся в DataGridView, операции DML выполняются
    /// параметрически через SqlCommand.
    /// </summary>
    public partial class SqlQueriesForm : Form
    {
        private static SqlQueriesForm _instance;

        public static SqlQueriesForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new SqlQueriesForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public SqlQueriesForm()
        {
            InitializeComponent();
            ConfigureQueryList();
        }

        private void ConfigureQueryList()
        {
            queryComboBox.Items.Clear();
            queryComboBox.Items.AddRange(new object[]
            {
                "1. Выборка контента",
                "2. Поиск по названию",
                "3. Контент и жанры (JOIN)",
                "4. Группировка по странам (с указанного года)",
                "5. Агрегатные функции",
                "6. Подзапрос IN",
                "7. Подзапрос EXISTS",
                "8. Скалярный подзапрос"
            });
            operationComboBox.SelectedIndex = 0;
            queryComboBox.SelectedIndex = 0;
            UpdateFormMode();
        }

        private void OperationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormMode();
        }

        private void QueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operationComboBox.SelectedIndex == 0)
                UpdateFormMode();
        }

        private void UpdateFormMode()
        {
            bool selectMode = operationComboBox.SelectedIndex == 0;
            bool insertMode = operationComboBox.SelectedIndex == 1;
            bool updateMode = operationComboBox.SelectedIndex == 2;
            bool deleteMode = operationComboBox.SelectedIndex == 3;
            bool searchQuery = queryComboBox.SelectedIndex == 1;
            bool groupedQuery = queryComboBox.SelectedIndex == 3;

            queryComboBox.Enabled = selectMode;
            executeSelectButton.Enabled = selectMode;
            queryLabel.Visible = selectMode;
            queryComboBox.Visible = selectMode;
            executeSelectButton.Visible = selectMode;
            insertButton.Enabled = !selectMode;
            insertButton.Visible = !selectMode;
            updateButton.Visible = false;
            deleteButton.Visible = false;

            if (insertMode)
                insertButton.Text = "Выполнить INSERT";
            else if (updateMode)
                insertButton.Text = "Выполнить UPDATE";
            else if (deleteMode)
                insertButton.Text = "Выполнить DELETE";

            nameTextBox.Enabled = false;
            originalNameTextBox.Enabled = false;
            yearTextBox.Enabled = false;
            typeTextBox.Enabled = false;
            countryTextBox.Enabled = false;
            datePicker.Enabled = false;
            idTextBox.Enabled = false;

            if (selectMode)
            {
                nameTextBox.Enabled = searchQuery;
                yearTextBox.Enabled = groupedQuery;
            }
            else if (insertMode)
            {
                nameTextBox.Enabled = true;
                originalNameTextBox.Enabled = true;
                yearTextBox.Enabled = true;
                typeTextBox.Enabled = true;
                countryTextBox.Enabled = true;
                datePicker.Enabled = true;
            }
            else if (updateMode)
            {
                nameTextBox.Enabled = true;
                idTextBox.Enabled = true;
            }
            else if (deleteMode)
            {
                idTextBox.Enabled = true;
            }

            if (selectMode && searchQuery)
            {
                yearLabel.Text = "Год:";
                statusLabel.Text = "Введите полностью или частично название контента.";
            }
            else if (selectMode && groupedQuery)
            {
                yearLabel.Text = "Год от:";
                statusLabel.Text = "Учитываются записи, выпущенные начиная с указанного года. Значение 1900 включает весь контент.";
            }
            else if (insertMode)
            {
                yearLabel.Text = "Год:";
                statusLabel.Text = "Заполните поля новой записи и нажмите INSERT.";
            }
            else if (updateMode)
            {
                yearLabel.Text = "Год:";
                statusLabel.Text = "Укажите ID записи и новое название, затем нажмите UPDATE.";
            }
            else if (deleteMode)
            {
                yearLabel.Text = "Год:";
                statusLabel.Text = "Укажите ID записи и нажмите DELETE.";
            }
            else
            {
                yearLabel.Text = "Год:";
                statusLabel.Text = "Выберите запрос и нажмите «Выполнить SELECT».";
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            switch (operationComboBox.SelectedIndex)
            {
                case 1:
                    InsertButton_Click(sender, e);
                    break;
                case 2:
                    UpdateButton_Click(sender, e);
                    break;
                case 3:
                    DeleteButton_Click(sender, e);
                    break;
            }
        }

        private void ExecuteSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    Properties.Settings.Default.VideoHostingDBConnectionString))
                using (SqlCommand command = BuildSelectCommand(connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    resultDataGridView.DataSource = result;
                    statusLabel.Text = "Запрос выполнен. Получено строк: " + result.Rows.Count + ".";
                }
            }
            catch (FormatException ex)
            {
                ShowError("Проверьте параметры запроса.", ex.Message);
            }
            catch (SqlException ex)
            {
                ShowError("Ошибка базы данных.", ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка выполнения запроса.", ex.Message);
            }
        }

        private SqlCommand BuildSelectCommand(SqlConnection connection)
        {
            string sql;
            switch (queryComboBox.SelectedIndex)
            {
                case 0:
                    sql = @"SELECT ID_контента, название, оригинальное_название,
                                   год_выпуска, страна_производства, тип_контента
                            FROM dbo.Контент
                            ORDER BY название";
                    break;
                case 1:
                    sql = @"SELECT ID_контента, название, год_выпуска, дата_поступления
                            FROM dbo.Контент
                            WHERE название LIKE @Название
                            ORDER BY год_выпуска DESC, название";
                    break;
                case 2:
                    sql = @"SELECT c.название AS Контент, g.Наименование AS Жанр
                            FROM dbo.Контент AS c
                            INNER JOIN dbo.Контент_Жанр AS cg
                                ON cg.ID_контента = c.ID_контента
                            INNER JOIN dbo.Жанр AS g
                                ON g.ID_жанра = cg.ID_жанра
                            ORDER BY c.название, g.Наименование";
                    break;
                case 3:
                    sql = @"SELECT страна_производства,
                                   COUNT(*) AS Количество,
                                   MIN(год_выпуска) AS ПервыйГод,
                                   MAX(год_выпуска) AS ПоследнийГод
                            FROM dbo.Контент
                            WHERE год_выпуска >= @ГодОтчёта
                            GROUP BY страна_производства
                            HAVING COUNT(*) >= 1
                            ORDER BY Количество DESC, страна_производства";
                    break;
                case 4:
                    sql = @"SELECT COUNT(*) AS ВсегоКонтента,
                                   COUNT(год_выпуска) AS КонтентСГодом,
                                   AVG(CONVERT(decimal(10, 2), год_выпуска)) AS СреднийГод,
                                   ISNULL(MIN(год_выпуска), 0) AS МинимальныйГод
                            FROM dbo.Контент";
                    break;
                case 5:
                    sql = @"SELECT ID_контента, название
                            FROM dbo.Контент
                            WHERE ID_контента IN
                            (SELECT ID_контента FROM dbo.Контент_Жанр)
                            ORDER BY название";
                    break;
                case 6:
                    sql = @"SELECT c.ID_контента, c.название
                            FROM dbo.Контент AS c
                            WHERE EXISTS
                            (SELECT 1 FROM dbo.Медиа_файл AS mf
                             WHERE mf.ID_контента = c.ID_контента)
                            ORDER BY c.название";
                    break;
                case 7:
                    sql = @"SELECT название, год_выпуска
                            FROM dbo.Контент
                            WHERE год_выпуска >
                            (SELECT AVG(CONVERT(decimal(10, 2), год_выпуска))
                             FROM dbo.Контент)
                            ORDER BY год_выпуска DESC";
                    break;
                default:
                    throw new InvalidOperationException("Не выбран запрос SELECT.");
            }

            SqlCommand command = new SqlCommand(sql, connection);

            if (queryComboBox.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                    throw new FormatException("Введите часть названия.");

                command.Parameters.Add("@Название", SqlDbType.NVarChar, 200)
                    .Value = "%" + nameTextBox.Text.Trim() + "%";
            }
            else if (queryComboBox.SelectedIndex == 3)
            {
                command.Parameters.Add("@ГодОтчёта", SqlDbType.SmallInt)
                    .Value = ReadYear(1900);
            }

            return command;
        }

        private short ReadYear(short defaultValue = 0)
        {
            if (string.IsNullOrWhiteSpace(yearTextBox.Text) && defaultValue != 0)
                return defaultValue;

            short year;
            if (!short.TryParse(yearTextBox.Text, out year) || year < 1888 || year > DateTime.Now.Year)
                throw new FormatException("Год должен быть числом от 1888 до текущего года.");
            return year;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ExecuteDml(@"INSERT INTO dbo.Контент
                (название, оригинальное_название, год_выпуска, страна_производства,
                 режиссёр, краткое_описание, возрастной_рейтинг, тип_контента,
                 длительность, дата_поступления, постер)
                VALUES (@Название, @ОригинальноеНазвание, @Год, @Страна,
                        @Режиссёр, @Описание, @Рейтинг, @Тип, @Длительность,
                        @ДатаПоступления, NULL)", AddInsertParameters);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ReadId();
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                    throw new FormatException("Для UPDATE введите новое название.");

                ExecuteDml(@"UPDATE dbo.Контент
                             SET название = @Название
                             WHERE ID_контента = @ID", command =>
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Название", SqlDbType.NVarChar, 200).Value = nameTextBox.Text.Trim();
                });
            }
            catch (FormatException ex)
            {
                ShowError("Проверьте параметры операции.", ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ReadId();
                ExecuteDml("DELETE FROM dbo.Контент WHERE ID_контента = @ID", command =>
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                });
            }
            catch (FormatException ex)
            {
                ShowError("Проверьте параметры операции.", ex.Message);
            }
        }

        private void ExecuteDml(string sql, Action<SqlCommand> addParameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    Properties.Settings.Default.VideoHostingDBConnectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    addParameters(command);
                    connection.Open();
                    int affected = command.ExecuteNonQuery();
                    statusLabel.Text = "Операция выполнена. Изменено строк: " + affected + ".";
                    MessageBox.Show(statusLabel.Text, "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                ShowError("Проверьте параметры операции.", ex.Message);
            }
            catch (SqlException ex)
            {
                ShowError("Ошибка базы данных.", ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка выполнения операции.", ex.Message);
            }
        }

        private void AddInsertParameters(SqlCommand command)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                throw new FormatException("Введите название для INSERT.");

            command.Parameters.Add("@Название", SqlDbType.NVarChar, 200).Value = nameTextBox.Text.Trim();
            command.Parameters.Add("@ОригинальноеНазвание", SqlDbType.NVarChar, 200).Value =
                string.IsNullOrWhiteSpace(originalNameTextBox.Text) ? nameTextBox.Text.Trim() : originalNameTextBox.Text.Trim();
            command.Parameters.Add("@Год", SqlDbType.SmallInt).Value = ReadYear();
            command.Parameters.Add("@Страна", SqlDbType.NVarChar, 100).Value =
                string.IsNullOrWhiteSpace(countryTextBox.Text) ? "Не указана" : countryTextBox.Text.Trim();
            command.Parameters.Add("@Режиссёр", SqlDbType.NVarChar, 200).Value = "Не указан";
            command.Parameters.Add("@Описание", SqlDbType.NVarChar, -1).Value = "Добавлено через форму ЛР4";
            command.Parameters.Add("@Рейтинг", SqlDbType.NVarChar, 20).Value = "12+";
            command.Parameters.Add("@Тип", SqlDbType.NVarChar, 50).Value =
                string.IsNullOrWhiteSpace(typeTextBox.Text) ? "Фильм" : typeTextBox.Text.Trim();
            command.Parameters.Add("@Длительность", SqlDbType.Time).Value = TimeSpan.Zero;
            command.Parameters.Add("@ДатаПоступления", SqlDbType.Date).Value = datePicker.Value.Date;
        }

        private int ReadId()
        {
            int id;
            if (!int.TryParse(idTextBox.Text, out id) || id <= 0)
                throw new FormatException("Введите положительный идентификатор контента.");
            return id;
        }

        private void ShowError(string title, string details)
        {
            statusLabel.Text = title;
            MessageBox.Show(title + "\n" + details, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
