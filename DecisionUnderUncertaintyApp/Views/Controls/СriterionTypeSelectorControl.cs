using System;
using System.Collections.Generic;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора типа критерия нахождения оптимального решения.
    /// </summary>
    public partial class СriterionTypeSelectorControl : SelectorControl<СriterionType>
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="СriterionTypeSelectorControl"/> по умолчанию.
        /// </summary>
        public СriterionTypeSelectorControl()
        {
            InitializeComponent();

            List<СriterionType> list = new List<СriterionType>();
            foreach(СriterionType type in Enum.GetValues(typeof(СriterionType)))
            {
                list.Add(type);
            }
            Items = list;
        }
    }
}