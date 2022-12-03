using System;
using System.Windows.Forms;

using GeneralizationApp.Services.IO;
using GeneralizationApp.Services.App;

namespace GeneralizationApp.Views.Forms
{
    public partial class MainForm : Form
    {
        private Settings _settings = new Settings();

        private Session _session = new Session();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveFormat save = new SaveFormat();
            try
            {
                save = JsonManager.Load<SaveFormat>(_settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
            finally
            {
                _session = save == null ? _session : save.Session;
                RankingExpertRatingTableTab.RankingExpertRatingTable = 
                    _session.RankingExpertRatingTable;
                ScoringExpertRatingTableTab.ScoringExpertRatingTable =
                    _session.ScoringExpertRatingTable;
                ObjectCriteriaTableTab.ObjectCriteriaRollupTable = 
                    _session.ObjectCriteriaRollupTable;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _session.RankingExpertRatingTable =
                RankingExpertRatingTableTab.RankingExpertRatingTable;
                _session.ScoringExpertRatingTable =
                    ScoringExpertRatingTableTab.ScoringExpertRatingTable;
                _session.ObjectCriteriaRollupTable =
                    ObjectCriteriaTableTab.ObjectCriteriaRollupTable;
                SaveFormat save = new SaveFormat(_session);
                JsonManager.Save(save, _settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}