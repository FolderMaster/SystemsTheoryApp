using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using GeneralizationApp.Services.Validators;

namespace GeneralizationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования массива вещественных чисел.
    /// </summary>
    public partial class DoubleTableGridControl : UserControl
    {
        /// <summary>
        /// Количество вещественных чисел.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Массив вещественных чисел.
        /// </summary>
        private double[] _doubleArray = new double[0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = CreateDataTable(0);

        /// <summary>
        /// Возращает и задаёт массив вещественных чисел.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double[] DoubleArray
        {
            get => _doubleArray;
            set
            {
                _doubleArray = value;
                _count = value.Length;
                _dataTable = CreateDataTable(_count);
                UpdateDataTable();
            }
        }

        /// <summary>
        /// Возращает и задаёт логическое значение, указывающее, только ли для чтения элемент.
        /// </summary>
        public bool IsReadOnly
        {
            get => DataGridView.ReadOnly;
            set => DataGridView.ReadOnly = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="DoubleTableGridControl"/> по умолчанию.
        /// </summary>
        public DoubleTableGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="count">Количество вещественных чисел.</param>
        /// <returns>Таблица.</returns>
        private static DataTable CreateDataTable(int count)
        {
            DataTable dataTable = new DataTable();
            for (int n = 0; n < count; ++n)
            {
                dataTable.Columns.Add($"{n + 1}", typeof(double));
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
                _dataTable.Rows[0][x] = DoubleArray[x];
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
            DoubleArray[columnIndex] = double.Parse(stringValue);
        }
    }
}