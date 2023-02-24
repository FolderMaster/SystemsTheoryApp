using System;
using System.Windows.Forms;

namespace ClassificationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора классификатора.
    /// </summary>
    public partial class ClassifierControl : UserControl
    {
        /// <summary>
        /// Возращает тип классификатора.
        /// </summary>
        public ClassifierType ClassifierType
        {
            get
            {
                return (ClassifierType)ComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Возращает количество соседей.
        /// </summary>
        public int NeighborsCount
        {
            get
            {
                return (int)NeighborsCountNumericUpDown.Value;
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ClassifierControl"/> по умолчанию.
        /// </summary>
        public ClassifierControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(ClassifierType));
        }

        private void ClassifyButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ClassifierType)
            {
                case ClassifierType.LinearClassifier: NeighborsCountLabel.Visible = false;
                    NeighborsCountNumericUpDown.Visible = false; break;
                case ClassifierType.NeighborClassifier: NeighborsCountLabel.Visible = true;
                    NeighborsCountNumericUpDown.Visible = true; break;
                default: throw new ArgumentException();
            }
        }
    }
}