using System;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора метода свёртки таблиц ранговой оценки экспертов.
    /// </summary>
    public partial class RankingGeneralizerControl : UserControl
    {
        /// <summary>
        /// Выбранный метод обобщения.
        /// </summary>
        public RankingGeneralizerType GeneralizationType
        {
            get => (RankingGeneralizerType)ComboBox.SelectedItem;
        }

        /// <summary>
        /// Обработчик данных события нажатия кнопки.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RankingGeneralizerControl"/> по умолчанию.
        /// </summary>
        public RankingGeneralizerControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(RankingGeneralizerType));
        }

        private void GeneralizeButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}