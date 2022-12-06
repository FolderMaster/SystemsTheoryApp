using System;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;
using SystemAnalysisMethodApp.Views.Forms;

namespace SystemAnalysisMethodApp.Views.Controls
{
    public partial class PairComparisonMatrixControl : UserControl
    {
        private PairComparisonMatrix _pairComparisonMatrix = null;
        
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRevisionNeeded
        {
            get => _pairComparisonMatrix.IsRevisionNeeded;
        }

        public event EventHandler PairComparisonMatrixChanged;

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
