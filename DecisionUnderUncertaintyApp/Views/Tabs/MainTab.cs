using System;
using System.ComponentModel;
using System.Windows.Forms;

using DecisionUnderUncertaintyApp.Models;
using DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion;
using DecisionUnderUncertaintyApp.Views.Forms;

namespace DecisionUnderUncertaintyApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для работы с таблицей вариантов и состояний среды.
    /// </summary>
    public partial class MainTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт таблицу вариантов и состояний среды.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OptionsEnvironmentsTable OptionsEnvironmentsTable
        {
            get => OptionsEnvironmentsTableControl.OptionsEnvironmentsTable;
            set => OptionsEnvironmentsTableControl.OptionsEnvironmentsTable = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainTab"/> по умолчанию.
        /// </summary>
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