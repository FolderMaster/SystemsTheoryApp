using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassificationApp.Services.IO;
using ClassificationApp.Services.App;
using ClassificationApp.Services.Classification;
using ClassificationApp.Views.Controls;

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
                EductaionCountryGridControl.Countries = _session.Education;
                TestCountryGridControl.Countries = _session.Test;
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

        private void ClassifierControl_ButtonClicked(object sender, EventArgs e)
        {
            IClassifier classifier = null;
            switch(ClassifierControl.ClassifierType)
            {
                case ClassifierType.LinearClassifier: classifier = new LinearClassifier(); break;
                case ClassifierType.NeighborClassifier: classifier = new
                        NeighborClassifier(ClassifierControl.NeighborsCount); break;
                default: throw new ArgumentException();
            }
            classifier.Educate(EductaionCountryGridControl.Countries);
            ResultForm form = new ResultForm();
            form.Countries = classifier.Classify(TestCountryGridControl.Countries);
            form.ShowDialog();
        }
    }
}