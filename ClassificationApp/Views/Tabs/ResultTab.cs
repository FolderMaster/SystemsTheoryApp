using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;
using ClassificationApp.Views.Controls;

namespace ClassificationApp.Views.Tabs
{
    public partial class ResultTab : UserControl
    {
        private string _classifierName = null;

        private TimeSpan _time = new TimeSpan();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Result
        {
            get => CountryGridControl.Countries;
            set => CountryGridControl.Countries = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            get => Scene3DDisplayControl.Scene3D;
            set => Scene3DDisplayControl.Scene3D = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassifierName
        {
            get => _classifierName;
            set
            {
                _classifierName = value;
                UpdateLabel();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Time
        {
            get => _time;
            set
            {
                _time = value;
                UpdateLabel();
            }
        }

        public ResultTab()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            ResultLabel.Text = $"The result was received by {ClassifierName} within {Time}";
        }
    }
}