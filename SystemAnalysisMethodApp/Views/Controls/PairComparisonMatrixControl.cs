using System;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;
using SystemAnalysisMethodApp.Views.Forms;

namespace SystemAnalysisMethodApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для работы с матрицей парных сравнений.
    /// </summary>
    public partial class PairComparisonMatrixControl : UserControl
    {
        /// <summary>
        /// Матрица парных сравнений.
        /// </summary>
        private PairComparisonMatrix _pairComparisonMatrix = null;
        
        /// <summary>
        /// Возращает и задаёт матрицу парных сравнений.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => _pairComparisonMatrix;
            set
            {
                _pairComparisonMatrix = value;
                PairComparisonMatrixGridControl.Matrix = value.Matrix;
                PairComparisonMatrixGridControl.Names = value.Names;
            }
        }

        /// <summary>
        /// Возращает логическое значение, указывающее, нужен ли пересмотр.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRevisionNeeded
        {
            get => _pairComparisonMatrix.IsRevisionNeeded;
        }

        /// <summary>
        /// Обработчик события изменения матрицы парных сравнений.
        /// </summary>
        public event EventHandler PairComparisonMatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonMatrixControl"/> по умолчанию.
        /// </summary>
        public PairComparisonMatrixControl()
        {
            InitializeComponent();
        }

        private void DoubleMatrixGridControl_MatrixChanged(object sender, EventArgs e)
        {
            string text = PairComparisonMatrix.IsRevisionNeeded ? "Revision needed" : 
                "No revision needed";
            Label.Text = text;
            PairComparisonMatrixChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            PairComparisonCalculationForm form = new PairComparisonCalculationForm();
            form.PairComparisonMatrix = PairComparisonMatrix;
            form.Show();
        }
    }
}
