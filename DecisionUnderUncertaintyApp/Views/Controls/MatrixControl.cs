using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования элементов матрицы.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public partial class MatrixControl<T> : UserControl
    {
        /// <summary>
        /// Количество столбцов.
        /// </summary>
        private int _columnCount = 0;

        /// <summary>
        /// Количество строчек.
        /// </summary>
        private int _rowCount = 0;

        /// <summary>
        /// Матрица.
        /// </summary>
        private T[,] _matrix = new T[0, 0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = new DataTable();

        /// <summary>
        /// Возращает и задаёт матрицу.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public T[,] Matrix
        {
            get => _matrix;
            set
            {
                if (!_matrix.Equals(value))
                {
                    _matrix = value;
                    _columnCount = value.GetLength(1);
                    _rowCount = value.GetLength(0);
                    _dataTable = CreateDataTable(_columnCount, _rowCount);
                    UpdateDataTable();
                    MatrixChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения матрицы.
        /// </summary>
        public event EventHandler MatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MatrixControl{T}"/> по умолчанию.
        /// </summary>
        public MatrixControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="columnCount">Количество столбцов.</param>
        /// <param name="rowCount">Количество строк.</param>
        /// <returns>Таблица.</returns>
        private DataTable CreateDataTable(int columnCount, int rowCount)
        {
            DataTable dataTable = new DataTable();
            string[] columnStrings = CreateColumnStrings(columnCount);
            string[] rowStrings = CreateRowStrings(rowCount);

            dataTable.Columns.Add("*", typeof(int));
            for (int n = 0; n < columnCount; ++n)
            {
                dataTable.Columns.Add(columnStrings[n], typeof(string));
            }
            if (dataTable.Columns.Count > 0)
            {
                dataTable.Columns[0].ReadOnly = true;
            }

            for (int n = 0; n < rowCount; ++n)
            {
                dataTable.Rows.Add(rowStrings[n]);
            }

            return dataTable;
        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateDataTable()
        {
            for (int y = 0; y < _rowCount; ++y)
            {
                for (int x = 0; x < _columnCount; x++)
                {
                    _dataTable.Rows[y][x + 1] = Matrix[y, x];
                }
            }
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Производит валидацию значения.
        /// </summary>
        /// <param name="value">Значение.</param>
        protected virtual void Validate(T value) { }

        /// <summary>
        /// Производит преобразование текста в значение.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Значение.</returns>
        protected virtual T Parse(string text) => default;

        /// <summary>
        /// Создаёт массив заголовков строк.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Массив заголовков строк.</returns>
        protected virtual string[] CreateRowStrings(int count)
        {
            string[] result = new string[count];
            for (int n = 0; n < count; ++n)
            {
                result[n] = $"{n + 1}";
            }
            return result;
        }

        /// <summary>
        /// Создаёт массив заголовков столбцов.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Массив заголовков столбцов.</returns>
        protected virtual string[] CreateColumnStrings(int count)
        {
            string[] result = new string[count];
            for (int n = 0; n < count; ++n)
            {
                result[n] = $"{n + 1}";
            }
            return result;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs
            e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                T value = Parse(e.FormattedValue.ToString());
                Validate(value);
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
            T currentValue = Parse(DataGridView[columnIndex, rowIndex].Value.ToString());
            if (!Matrix[rowIndex, columnIndex - 1].Equals(currentValue))
            {
                Matrix[rowIndex, columnIndex - 1] = currentValue;
                MatrixChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}