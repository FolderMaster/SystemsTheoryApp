using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Views.Controls
{
    public partial class PairComparisonMatrixGridControl : UserControl
    {
        private double[,] _matrix = new double[0, 0];

        private string[] _names = new string[0];

        private DataTable _dataTable = CreateDataTable(0, new string[0]);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[,] Matrix
        {
            get => _matrix;
            set
            {
                ValueValidator.AssertMatrixIsSquare(value, nameof(Matrix));
                _matrix = value;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
                _dataTable = CreateDataTable(Count, Names);
                UpdateDataTable();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string[] Names
        {
            get => _names;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(Names));
                _names = value;
                _dataTable = CreateDataTable(Count, Names);
                UpdateDataTable();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count
        {
            get => _matrix.GetLength(0);
        }

        public event EventHandler MatrixChanged;

        public PairComparisonMatrixGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private static DataTable CreateDataTable(int count, string[] names)
        {
            DataTable dataTable = new DataTable();
            if (names.Length != count)
            {
                names = new string[count];
            }

            dataTable.Columns.Add("*", typeof(string));
            for (int n = 0; n < count; ++n)
            {
                dataTable.Columns.Add(names[n], typeof(double));
            }
            if (dataTable.Columns.Count > 0)
            {
                dataTable.Columns[0].ReadOnly = true;
            }

            for (int n = 0; n < count; ++n)
            {
                dataTable.Rows.Add(names[n]);
            }

            return dataTable;
        }

        private void UpdateDataTable()
        {
            for (int y = 0; y < Count; ++y)
            {
                for (int x = 0; x < Count; x++)
                {
                    _dataTable.Rows[y][x + 1] = Matrix[y, x];
                }
            }
            DataGridView.DataSource = _dataTable;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            if(columnIndex != 0)
            {
                try
                {
                    double value = double.Parse((string)e.FormattedValue);
                    ValueValidator.AssertIsElementOfPairComparisonMatrix(value, $"TableMatrix[{rowIndex}, " +
                        $"{columnIndex - 1}]");
                    DataGridView[columnIndex, rowIndex].ErrorText = "";
                    DataGridView[columnIndex, rowIndex].Style.BackColor = 
                        ColorManager.CorrectColor;
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    DataGridView[columnIndex, rowIndex].ErrorText = ex.Message;
                    DataGridView[columnIndex, rowIndex].Style.BackColor = 
                        ColorManager.ErrorColor;
                }
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            object value = DataGridView[columnIndex, rowIndex].Value;
            string stringValue = value == null ? "" : value.ToString();
            Matrix[rowIndex, columnIndex - 1] = double.Parse(stringValue);
            MatrixChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}