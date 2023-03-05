using System;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора метода свёртки таблиц оценок альтернатив.
    /// </summary>
    public partial class RolluperControl : UserControl
    {
        /// <summary>
        /// Выбранный метод свёртки.
        /// </summary>
        public RolluperType RolluperType
        {
            get => (RolluperType)ComboBox.SelectedItem;
        }

        /// <summary>
        /// Обработчик данных события нажатия кнопки.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RolluperControl"/> по умолчанию.
        /// </summary>
        public RolluperControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(RolluperType));
        }

        private void RollupButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}