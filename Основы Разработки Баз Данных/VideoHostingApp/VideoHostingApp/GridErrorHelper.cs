using System.Windows.Forms;

namespace VideoHostingApp
{
    /// <summary>
    /// Общий вспомогательный класс для отображения ошибок ввода в DataGridView.
    /// Используется обработчиками события DataError форм-справочников.
    /// </summary>
    internal static class GridErrorHelper
    {
        /// <summary>
        /// Показывает пользователю сообщение о некорректном значении,
        /// введённом в ячейку DataGridView (например, значение не из выпадающего списка).
        /// </summary>
        /// <param name="message">Текст сообщения, поясняющий, что именно нужно исправить.</param>
        internal static void ShowComboBoxError(string message)
        {
            MessageBox.Show(message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
