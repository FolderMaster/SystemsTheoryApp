using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class ArrayControl<T> : UserControl
    {
        private int _count = 0;

        private T[] _array = new T[0];

        private DataTable _dataTable = new DataTable();

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

        public event EventHandler ArrayChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ÍsReadOnly
        {
            get => DataGridView.ReadOnly;
            set => DataGridView.ReadOnly = value;
        }

        public ArrayControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

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

        private void UpdateDataTable()
        {
            for (int x = 0; x < _count; ++x)
            {
                _dataTable.Rows[0][x] = Array[x];
            }
            DataGridView.DataSource = _dataTable;
        }

        protected virtual void Validate(T value) { }

        protected virtual T Parse(string text) => default;

        protected virtual string[] CreateColumnStrings(int count)
        {
            string[] result = new string[count];
            for (int n = 0; n < count; ++n)
            {
                result[n] = $"{n + 1}";
            }
            return result;
        }

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
