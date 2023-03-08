using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для отображения результата.
    /// </summary>
    public partial class ResultTab : UserControl
    {
        /// <summary>
        /// Задаёт массив решений.
        /// </summary>
        public double[] Array
        {
            set => DoubleArrayControl.Array = value;
        }

        /// <summary>
        /// Задаёт индекс оптимального решения.
        /// </summary>
        public int Index
        {
            set => DoubleArrayControl.SetSelectedIndex(value);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ResultTab"/> по умолчанию.
        /// </summary>
        public ResultTab()
        {
            InitializeComponent();
        }
    }
}