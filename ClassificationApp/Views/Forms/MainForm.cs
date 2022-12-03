using System;
using System.Windows.Forms;

using ClassificationApp.Services.IO;
using ClassificationApp.Services.App;

namespace ClassificationApp.Views.Forms
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
                MainTab.Education = _session.Education;
                MainTab.Test = _session.Test;
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