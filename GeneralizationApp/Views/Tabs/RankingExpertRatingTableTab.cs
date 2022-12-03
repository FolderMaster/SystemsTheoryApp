﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

using GeneralizationApp.Models;
using GeneralizationApp.Services.Generalizaters;
using GeneralizationApp.Views.Controls;
using GeneralizationApp.Views.Forms;

namespace GeneralizationApp.Views.Tabs
{
    public partial class RankingExpertRatingTableTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RankingExpertRatingTable RankingExpertRatingTable
        {
            get => RankingExpertRatingTableControl.RankingExpertRatingTable;
            set => RankingExpertRatingTableControl.RankingExpertRatingTable = value;
        }

        public RankingExpertRatingTableTab()
        {
            InitializeComponent();
        }

        private void RankingGeneralizerControl_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                int[] result;
                Stopwatch stopwatch = new Stopwatch();
                switch (RankingGeneralizerControl.GeneralizationType)
                {
                    case RankingGeneralizerType.RangingGeneralizer:
                        stopwatch.Start();
                        result = RankingExpertRatingTableGeneralizer.
                            RangingGeneralize(RankingExpertRatingTable);
                        stopwatch.Stop();
                        break;
                    case RankingGeneralizerType.PairComparisonGeneralizer:
                        stopwatch.Start();
                        result = RankingExpertRatingTableGeneralizer.
                            PairComparisonGeneralize(RankingExpertRatingTable);
                        stopwatch.Stop();
                        break;
                    default: throw new ArgumentException();
                }
                string generalizerName = RankingGeneralizerControl.GeneralizationType.ToString();
                ResultForm resultForm = new ResultForm();
                resultForm.GeneralizerName = generalizerName;
                resultForm.Result = result;
                resultForm.Time = stopwatch.Elapsed;
                resultForm.Show();
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}