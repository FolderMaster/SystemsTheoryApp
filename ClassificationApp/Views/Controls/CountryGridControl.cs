using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassificationApp.Models;

namespace ClassificationApp.Views.Controls
{
    public partial class CountryGridControl : UserControl
    {
        private List<Country> _countries = new List<Country>();

        private DataTable _dataTable = CreateDataTable();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => _countries;
            set
            {
                _countries = value;
                _dataTable.Rows.Clear();
                UpdateDataTable();
            }
        }

        public CountryGridControl()
        {
            InitializeComponent();
            DataGridView.DataSource = _dataTable;
        }

        private static DataTable CreateDataTable()
        {
            DataTable dateTable = new DataTable();
            dateTable.Columns.Add("Type", typeof(Country.CountryType));
            dateTable.Columns.Add("GDP", typeof(double));
            dateTable.Columns.Add("Debt", typeof(double));
            dateTable.Columns.Add("Density", typeof(double));
            return dateTable;
        }

        private void UpdateDataTable()
        {
            _dataTable.Rows.Clear();
            foreach (Country country in _countries)
            {
                _dataTable.Rows.Add(country.Type, country.Gdp, country.Debt, country.Density);
            }
            DataGridView.DataSource = _dataTable;
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            try
            {
                object value = DataGridView[columnIndex, rowIndex].Value;
                string stringValue = value == null ? "" : value.ToString();
                switch (columnIndex)
                {
                    case 0:
                        Countries[rowIndex].Type = (Country.CountryType)Enum.
                            Parse(typeof(Country.CountryType), stringValue); break;
                    case 1: Countries[rowIndex].Gdp = double.Parse(stringValue); break;
                    case 2: Countries[rowIndex].Debt = double.Parse(stringValue); break;
                    case 3: Countries[rowIndex].Density = double.Parse(stringValue); break;
                    default: new AggregateException(); break;
                }
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.CorrectColor;
            }
            catch
            {
                DataGridView[columnIndex, rowIndex].Style.BackColor = ColorManager.ErrorColor;
            }
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = ColorManager.ErrorColor;
        }

        private void DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Countries.Add(new Country());
            UpdateDataTable();
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            Countries.RemoveAt(index);
        }
    }
}