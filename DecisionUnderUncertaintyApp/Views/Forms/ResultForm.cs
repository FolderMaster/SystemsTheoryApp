using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Forms
{
    /// <summary>
    /// Окно приложения для отображения результата.
    /// </summary>
    public partial class ResultForm : Form
    {
        /// <summary>
        /// Задаёт массив решений.
        /// </summary>
        public double[] Array
        {
            set => ResultTab.Array = value;
        }

        /// <summary>
        /// Задаёт индекс оптимального решения.
        /// </summary>
        public int Index
        {
            set => ResultTab.Index = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ResultForm"/>.
        /// </summary>
        /// <param name="array">Массив  решений.</param>
        /// <param name="index">Индекс оптимального решения.</param>
        public ResultForm(double[] array, int index)
        {
            InitializeComponent();

            Array = array;
            Index = index;
        }
    }
}