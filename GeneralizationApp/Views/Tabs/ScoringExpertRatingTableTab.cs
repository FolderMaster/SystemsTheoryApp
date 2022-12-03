using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

using GeneralizationApp.Models;
using GeneralizationApp.Services.Generalizaters;
using GeneralizationApp.Views.Controls;
using GeneralizationApp.Views.Forms;

namespace GeneralizationApp.Views.Tabs
{
    public partial class ScoringExpertRatingTableTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ScoringExpertRatingTable ScoringExpertRatingTable
        {
            get => ScoringExpertRatingTableControl.ScoringExpertRatingTable;
            set => ScoringExpertRatingTableControl.ScoringExpertRatingTable = value;
        }

        public ScoringExpertRatingTableTab()
        {
            InitializeComponent();
        }

        private void GeneralizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int[] result;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                result = ScoringExpertRatingTableGeneralizer.Generalize(ScoringExpertRatingTable);
                stopwatch.Stop();
                string generalizerName = "ScoringGeneralizer";
                ResultForm resultForm = new ResultForm();
                resultForm.GeneralizerName = generalizerName;
                resultForm.Result = result;
                resultForm.Time = stopwatch.Elapsed;
                resultForm.Show();
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}