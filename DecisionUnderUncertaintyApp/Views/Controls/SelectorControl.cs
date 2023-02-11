using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class SelectorControl<T> : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        private List<T> _items = new List<T>();

        private T _selectedItem = default;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<T> Items
        {
            get => _items;
            set
            {
                _items = value;
                _bindingSource.DataSource = _items;
                if (_items.Count > 0)
                {
                    ComboBox.SelectedIndex = 0;
                    SelectedItem = (T)ComboBox.SelectedItem;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public T SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (!SelectedItem.Equals(value))
                {
                    _selectedItem = value;
                    SelectedItemChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectedItemChanged;

        public SelectorControl()
        {
            InitializeComponent();

            ComboBox.DataSource = _bindingSource;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (T)ComboBox.SelectedItem;
        }
    }
}
