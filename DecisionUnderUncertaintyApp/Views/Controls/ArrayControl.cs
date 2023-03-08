using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования элементов массива.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public partial class ArrayControl<T> : UserControl
    {
        /// <summary>
        /// Количество.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Массив.
        /// </summary>
        private T[] _array = new T[0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = new DataTable();

        /// <summary>
        /// Возращает и задаёт массив.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public T[] Array
        {
            get => _array;
            set
            {
                if (!_array.Equals(value))
                {
                    _array = value;
                    _count = value.Length;
                    _dataTable = CreateDataTable(_count);
                    UpdateDataTable();
                    ArrayChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения массива.
        /// </summary>
        public event EventHandler ArrayChanged;

        /// <summary>
        /// Возращает и задаёт логическое значение, указывающее, только ли для чтения элемент
        /// управления.
        /// </summary>
        public bool IsReadOnly
        {
            get => DataGridView.ReadOnly;
            set => DataGridView.ReadOnly = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ArrayControl{T}"/> по умолчанию.
        /// </summary>
        public ArrayControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <returns>Таблица.</returns>
        private DataTable CreateDataTable(int count)
        {
            DataTable dataTable = new DataTable();
            string[] columnStrings = CreateColumnStrings(count);

            for (int n = 0; n < count; ++n)
            {
                dataTable.Columns.Add(columnStrings[n], typeof(string));
            }
            dataTable.Rows.Add();

            return dataTable;
        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateDataTable()
        {
            for (int x = 0; x < _count; ++x)
            {
                _dataTable.Rows[0][x] = Array[x];
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

        /// <summary>
        /// Устанавливает выбор на индексе.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public void SetSelectedIndex(int index)
        {
            DataGridView.Columns[index].DefaultCellStyle.BackColor = ColorManager.AnswerColor;
            DataGridView.Columns[index].DefaultCellStyle.SelectionBackColor =
                ColorManager.SelectedAnswerColor;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
            if (!Array[columnIndex].Equals(currentValue))
            {
                Array[columnIndex] = currentValue;
                ArrayChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}