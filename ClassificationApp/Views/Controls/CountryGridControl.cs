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

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Views.Controls
{
    public partial class CountryGridControl : UserControl
    {
        BindingList<Country> _bindingList = new BindingList<Country>();

        BindingSource _bindingSource = new BindingSource();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => _bindingList.ToList();
            set
            {
                _bindingList = new BindingList<Country>(value);
                DataGridView.DataSource = _bindingList;
            }
        }

        public CountryGridControl()
        {
            InitializeComponent();
            _bindingSource.DataSource = _bindingList;
            DataGridView.DataSource = _bindingSource;
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView[e.ColumnIndex, e.RowIndex].ErrorText = e.Exception.Message;
            e.Cancel = true;
        }

        private void DataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView[e.ColumnIndex, e.RowIndex].ErrorText = null;
        }
    }
}