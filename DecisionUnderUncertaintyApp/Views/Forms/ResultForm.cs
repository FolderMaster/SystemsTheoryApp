using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionUnderUncertaintyApp.Views.Forms
{
    public partial class ResultForm : Form
    {
        public double[] Array
        {
            set => ResultTab.Array = value;
        }

        public int Index
        {
            set => ResultTab.Index = value;
        }

        public ResultForm(double[] array, int index)
        {
            InitializeComponent();

            Array = array;
            Index = index;
        }
    }
}
