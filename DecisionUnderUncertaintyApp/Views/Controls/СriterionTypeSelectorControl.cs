using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    public partial class СriterionTypeSelectorControl : SelectorControl<СriterionType>
    {
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
