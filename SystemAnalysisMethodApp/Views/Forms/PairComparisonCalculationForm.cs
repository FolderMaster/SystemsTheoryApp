using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    /// <summary>
    /// Окно отображения рассчётов матрицы парных отображений.
    /// </summary>
    public partial class PairComparisonCalculationForm : Form
    {
        /// <summary>
        /// Задаёт матрицу парных сравнений.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            set => PairComparisonCalculationTab.PairComparisonMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonCalculationForm"/> по умолчанию.
        /// </summary>
        public PairComparisonCalculationForm()
        {
            InitializeComponent();
        }
    }
}