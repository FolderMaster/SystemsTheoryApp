using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    /// <summary>
    /// Окно работы с матрицей парных отображений.
    /// </summary>
    public partial class PairComparisonForm : Form
    {
        /// <summary>
        /// Возращает и задаёт матрицу парных сравнений.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonTab.PairComparisonMatrix;
            set => PairComparisonTab.PairComparisonMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonForm"/> по умолчанию.
        /// </summary>
        public PairComparisonForm()
        {
            InitializeComponent();
        }
    }
}
