using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для работы со списком стран.
    /// </summary>
    public partial class CountryGridControl : UserControl
    {
        /// <summary>
        /// Список источника данных для <see cref="_bindingSource"/>.
        /// </summary>
        private BindingList<Country> _bindingList = new BindingList<Country>();

        /// <summary>
        /// Источник данных для <see cref="DataGridView"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Логическое значение, указывающее, что доступно редактирование.
        /// </summary>
        private bool _isEditor = true;

        /// <summary>
        /// Возращает и задаёт список стран.
        /// </summary>
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

        /// <summary>
        /// Возращает и задаёт логическое значение, указывающее, что доступно редактирование.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CountryGridControl"/> по умолчанию.
        /// </summary>
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