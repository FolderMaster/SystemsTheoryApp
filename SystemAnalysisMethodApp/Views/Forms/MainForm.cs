using System;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Services.IO;
using SystemAnalysisMethodApp.Services.App;

namespace SystemAnalysisMethodApp.Views.Forms
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
                MainTab.Countries = _session.Countries;
                MainTab.PairComparisonMatrix = _session.PairComparisonMatrix;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
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