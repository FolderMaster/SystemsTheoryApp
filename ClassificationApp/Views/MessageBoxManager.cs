using System.Windows.Forms;

namespace ClassificationApp.Views
{
    /// <summary>
    /// Класс менеджер окон сообщений, предоставляющий методы показа окон сообщений.
    /// </summary>
    public static class MessageBoxManager
    {
        /// <summary>
        /// Показывает окно сообщения с ошибкой.
        /// </summary>
        /// <param name="text">Текст ошибки.</param>
        /// <returns>Окно сообщения с ошибкой.</returns>
        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Показывает окно сообщения с информацией.
        /// </summary>
        /// <param name="text">Текст информации.</param>
        /// <returns>Окно сообщения с информацией.</returns>
        public static DialogResult ShowInformation(string text)
        {
            return MessageBox.Show(text, "Information!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}