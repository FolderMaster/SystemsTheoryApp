using System;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    public partial class PairComparisonCalculationTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            set
            {
                ChangeVectorGridView(value);
                ChangeLmaxGridView(value);
                ChangeConsistencyRelationTextBox(value);
            }
        }

        public PairComparisonCalculationTab()
        {
            InitializeComponent();
        }

        private void ChangeVectorGridView(PairComparisonMatrix matrix)
        {
            VectorGridView.Rows.Clear();
            VectorGridView.Columns.Clear();
            VectorGridView.Columns.Add("NamesColumn", "Names");
            for (int n = 0; n < matrix.Count; ++n)
            {
                VectorGridView.Columns.Add($"{matrix.Names[n]}Column", matrix.Names[n]);
            }
            VectorGridView.Columns.Add("OwnVectorColumn", "OwnVector");
            VectorGridView.Columns.Add("NormalisedVectorColumn",
                "NormalisedVector");
            for (int n = 0; n < matrix.Count; ++n)
            {
                VectorGridView.Rows.Add(matrix.Names[n]);
                for (int i = 0; i < matrix.Count; ++i)
                {
                    VectorGridView.Rows[n].Cells[i + 1].Value = matrix.Matrix[n, i];
                }
                VectorGridView.Rows[n].Cells[matrix.Count + 1].Value = matrix.GetOwnVector(n);
                VectorGridView.Rows[n].Cells[matrix.Count + 2].Value = 
                    matrix.GetNormalizedVector(n);
            }
            VectorGridView.Rows.Add("Sum");
            VectorGridView.Rows[matrix.Count].Cells[matrix.Count + 1].Value = matrix.SumOwnVectors;
            ResizeVectorGridView();
        }

        private void ChangeLmaxGridView(PairComparisonMatrix matrix)
        {
            LmaxGridView.Rows.Clear();
            LmaxGridView.Columns.Clear();
            LmaxGridView.Columns.Add("HeaderColumn", "*");
            for (int n = 0; n < matrix.Count; ++n)
            {
                LmaxGridView.Columns.Add($"{matrix.Names[n]}Column", matrix.Names[n]);
            }
            LmaxGridView.Columns.Add("LmaxColumn", "Lmax");
            LmaxGridView.Rows.Add("Column sum");
            LmaxGridView.Rows.Add("Multiply column sum and normalized vector");
            for (int n = 0; n < matrix.Count; ++n)
            {
                LmaxGridView.Rows[0].Cells[n + 1].Value = matrix.GetColumnSum(n);
                LmaxGridView.Rows[1].Cells[n + 1].Value =
                    matrix.GetMultiplyColumnSumAndNormalizedVector(n);
            }
            LmaxGridView.Rows[1].Cells[matrix.Count + 1].Value = matrix.Lmax;
            ResizeLmaxGridView();
        }

        private void ChangeConsistencyRelationTextBox(PairComparisonMatrix matrix)
        {
            ConsistencyRelationTextBox.Text = "ConsistencyRelation = (Lmax - Count) / (Count - 1" +
                $") / RandomConsistency = ({matrix.Lmax} - {matrix.Count}) / ({matrix.Count} - 1" +
                $") / {matrix.RandomConsistency} = {matrix.ConsistencyRelation}";
            if (matrix.IsRevisionNeeded)
            {
                ConsistencyRelationTextBox.Text += " >= 0.10";
            }
            else
            {
                ConsistencyRelationTextBox.Text += " < 0.10";
            }
        }

        private void ResizeVectorGridView()
        {
            foreach (DataGridViewRow row in VectorGridView.Rows)
            {
                row.Height = (VectorGridView.ClientRectangle.Height - 
                    VectorGridView.ColumnHeadersHeight) / 
                    VectorGridView.Rows.Count;
            }
        }

        private void ResizeLmaxGridView()
        {
            foreach (DataGridViewRow row in LmaxGridView.Rows)
            {
                row.Height = (LmaxGridView.ClientRectangle.Height - 
                    LmaxGridView.ColumnHeadersHeight) / LmaxGridView.Rows.Count;
            }
        }

        private void PairComparisonMatrixGridView_SizeChanged(object sender, EventArgs e)
        {
            ResizeVectorGridView();
        }

        private void LmaxGridView_SizeChanged(object sender, EventArgs e)
        {
            ResizeLmaxGridView();
        }
    }
}