using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Views.Controls
{
    public partial class DoubleTableGridControl : UserControl
    {
        private int _count = 0;

        private double[] _tableMatrix = new double[0];

        private DataTable _dataTable = CreateDataTable(0);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                _tableMatrix = value;
                _count = value.Length;
                _dataTable = CreateDataTable(_count);
                UpdateDataTable();
            }
        }

        public bool IsReadOnly
        {
            get => DataGridView.ReadOnly;
            set => DataGridView.ReadOnly = value;
        }

        public DoubleTableGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private static DataTable CreateDataTable(int weightCount)
        {
            DataTable dataTable = new DataTable();
            for (int n = 0; n < weightCount; ++n)
            {
                dataTable.Columns.Add($"{n + 1}", typeof(double));
            }
            dataTable.Rows.Add();
            return dataTable;
        }

        private void UpdateDataTable()
        {
            for (int x = 0; x < _count; x++)
            {
                _dataTable.Rows[0][x] = TableMatrix[x];
            }
            DataGridView.DataSource = _dataTable;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                double value = double.Parse((string)e.FormattedValue);
                ValueValidator.AssertValueIsPositive(value, $"TableMatrix[{rowIndex}, " +
                    $"{columnIndex - 1}]");
                DataGridView[columnIndex, rowIndex].ErrorText = "";
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.CorrectColor;
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                DataGridView[columnIndex, rowIndex].ErrorText = ex.Message;
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.ErrorColor;
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            object value = DataGridView[columnIndex, rowIndex].Value;
            string stringValue = value == null ? "" : value.ToString();
            TableMatrix[columnIndex] = double.Parse(stringValue);
        }
    }
}