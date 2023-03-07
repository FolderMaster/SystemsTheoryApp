using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для редактирования матрицы парных сравнений.
    /// </summary>
    public partial class PairComparisonMatrixGridControl : UserControl
    {
        /// <summary>
        /// Матрица.
        /// </summary>
        private double[,] _matrix = new double[0, 0];

        /// <summary>
        /// Названия.
        /// </summary>
        private string[] _names = new string[0];

        /// <summary>
        /// Таблица.
        /// </summary>
        private DataTable _dataTable = CreateDataTable(0, new string[0]);

        /// <summary>
        /// Возращает и задаёт матрицу. Должна быть квадратной.
        /// </summary>
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
                ResizeDataGridView();
            }
        }

        /// <summary>
        /// Возращает и задаёт названия. Должна быть не пустой.
        /// </summary>
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
                ResizeDataGridView();
            }
        }

        /// <summary>
        /// Возращает и задаёт длину матрицу.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count
        {
            get => _matrix.GetLength(0);
        }

        /// <summary>
        /// Обработчик события изменения матрицы.
        /// </summary>
        public event EventHandler MatrixChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PairComparisonMatrixGridControl"/> по умолчанию.
        /// </summary>
        public PairComparisonMatrixGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        /// <summary>
        /// Создаёт таблицу.
        /// </summary>
        /// <param name="count">Длина матрицы.</param>
        /// <param name="names">Названия.</param>
        /// <returns>Таблица с названиями.</returns>
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

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
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

        /// <summary>
        /// Перестраивает представление таблицы.
        /// </summary>
        private void ResizeDataGridView()
        {
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                row.Height = (DataGridView.ClientRectangle.Height -
                    DataGridView.ColumnHeadersHeight) / DataGridView.Rows.Count;
            }
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs
            e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            if(columnIndex != 0)
            {
                try
                {
                    double value = double.Parse((string)e.FormattedValue);
                    ValueValidator.AssertIsElementOfPairComparisonMatrix(value, $"TableMatrix[" +
                        $"{rowIndex}, {columnIndex - 1}]");
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

        private void DataGridView_SizeChanged(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }

        private void PairComparisonMatrixGridControl_Load(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }
    }
}