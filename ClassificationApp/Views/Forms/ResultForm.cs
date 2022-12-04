using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Views.Forms
{
    public partial class ResultForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => ResultTab.Result;
            set => ResultTab.Result = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            get => ResultTab.Scene3D;
            set => ResultTab.Scene3D = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassifierName
        {
            get => ResultTab.ClassifierName;
            set => ResultTab.ClassifierName = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Time
        {
            get => ResultTab.Time;
            set => ResultTab.Time = value;
        }

        public ResultForm()
        {
            InitializeComponent();
        }
    }
}