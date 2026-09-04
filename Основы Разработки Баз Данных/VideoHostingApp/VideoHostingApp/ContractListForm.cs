using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoHostingApp
{
    public partial class ContractListForm : Form
    {
        #region Singleton
        private static ContractListForm instance;
        public static ContractListForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new ContractListForm();
                return instance;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        #endregion

        #region Конструктор
        public ContractListForm()
        {
            InitializeComponent();
            contractDataGridView.DataError += ContractDataGridView_DataError;
        }
        #endregion

        #region Загрузка
        private void ContractListForm_Load(object sender, EventArgs e)
        {
            this.contractTableAdapter.Fill(this.videoHostingDBDataSet.Договор);
        }
        #endregion

        #region Сохранение
        private void ContractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contractBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
                MessageBox.Show("Данные сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Обработка ошибок
        private void ContractDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Выберите тип лицензии из списка.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
