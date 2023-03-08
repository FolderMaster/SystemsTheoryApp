using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора элемента в списке.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public partial class SelectorControl<T> : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ComboBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Список элементов.
        /// </summary>
        private List<T> _items = new List<T>();

        /// <summary>
        /// Выбранный элемент.
        /// </summary>
        private T _selectedItem = default;

        /// <summary>
        /// Возращает и задаёт список элементов.
        /// </summary>
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

        /// <summary>
        /// Возраащет и задаёт выбранный элемент.
        /// </summary>
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

        /// <summary>
        /// Обработчик события изменения выбранного элемента.
        /// </summary>
        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SelectorControl{T}"/> по умолчанию.
        /// </summary>
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