using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class BoolTableGridControl : UserControl
    {
        private int _count = 0;

        private bool[] _tableMatrix = new bool[0];

        private DataTable _dataTable = CreateDataTable(0);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool[] TableMatrix
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

        public BoolTableGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private static DataTable CreateDataTable(int weightCount)
        {
            DataTable dataTable = new DataTable();
            for (int n = 0; n < weightCount; ++n)
            {
                dataTable.Columns.Add($"{n + 1}", typeof(bool));
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

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            object value = DataGridView[columnIndex, rowIndex].Value;
            TableMatrix[columnIndex] = (bool)value;
        }
    }
}
