using System;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для работы с матрицей парных сравнений.
    /// </summary>
    public partial class PairComparisonTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт матрицу парных сравнений.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonMatrixControl.PairComparisonMatrix;
            set => PairComparisonMatrixControl.PairComparisonMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonTab"/> по умолчанию.
        /// </summary>
        public PairComparisonTab()
        {
            InitializeComponent();
        }

        private void PairComparisonMatrixControl_PairComparisonMatrixChanged(object sender,
            EventArgs e)
        {
            if(PairComparisonMatrixControl.IsRevisionNeeded)
            {
                OKButton.Enabled = false;
            }
            else
            {
                OKButton.Enabled = true;
            }
        }
    }
}