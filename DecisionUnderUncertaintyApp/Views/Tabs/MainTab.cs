using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DecisionUnderUncertaintyApp.Models;
using DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion;
using DecisionUnderUncertaintyApp.Views.Forms;

namespace DecisionUnderUncertaintyApp.Views.Tabs
{
    public partial class MainTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OptionsEnvironmentsTable OptionsEnvironmentsTable
        {
            get => OptionsEnvironmentsTableControl.OptionsEnvironmentsTable;
            set => OptionsEnvironmentsTableControl.OptionsEnvironmentsTable = value;
        }

        public MainTab()
        {
            InitializeComponent();
        }

        private void CriterionControl_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                IDecissionSearchСriterion iDecissionSearchСriterion =
                CriterionControl.IDecissionSearchСriterion;
                double[] array =
                    iDecissionSearchСriterion.EvaluateDecissions(OptionsEnvironmentsTable);
                int index = iDecissionSearchСriterion.SearchBestDecission(array);
                ResultForm form = new ResultForm(array, index);
                form.Show();
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}