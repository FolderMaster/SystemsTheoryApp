using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Controls
{
    public partial class CountryGridControl : UserControl
    {
        private BindingList<Country> _bindingList = new BindingList<Country>();

        private BindingSource _bindingSource = new BindingSource();

        private bool _isEditor = true;

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

        public bool IsEditor
        {
            get => _isEditor;
            set
            {
                _isEditor = value;
                if(value)
                {
                    DataGridView.ReadOnly = false;
                }
                else
                {
                    DataGridView.ReadOnly = true;
                }
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