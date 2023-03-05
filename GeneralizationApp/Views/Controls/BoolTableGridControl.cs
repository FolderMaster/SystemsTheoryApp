using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования массива логических значений.
    /// </summary>
    public partial class BoolTableGridControl : UserControl
    {
        /// <summary>
        /// Количество флагов.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Массив логических значений.
        /// </summary>
        private bool[] _boolArray = new bool[0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = CreateDataTable(0);

        /// <summary>
        /// Возращает и задаёт массив логических значений.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool[] BoolArray
        {
            get => _boolArray;
            set
            {
                _boolArray = value;
                _count = value.Length;
                _dataTable = CreateDataTable(_count);
                UpdateDataTable();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="BoolTableGridControl"/> по умолчанию.
        /// </summary>
        public BoolTableGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="count">Количество флагов.</param>
        /// <returns>Таблица.</returns>
        private static DataTable CreateDataTable(int count)
        {
            DataTable dataTable = new DataTable();
            for (int n = 0; n < count; ++n)
            {
                dataTable.Columns.Add($"{n + 1}", typeof(bool));
            }
            dataTable.Rows.Add();
            return dataTable;
        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateDataTable()
        {
            for (int x = 0; x < _count; x++)
            {
                _dataTable.Rows[0][x] = BoolArray[x];
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
            BoolArray[columnIndex] = (bool)value;
        }
    }
}
