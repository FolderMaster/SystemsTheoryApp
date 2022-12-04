﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Services.Classification;
using ClassificationApp.Services.Factories;
using ClassificationApp.Views.Controls;
using ClassificationApp.Views.Forms;

namespace ClassificationApp.Views.Tabs
{
    public partial class MainTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Education
        {
            get => EductaionCountryGridControl.Countries;
            set => EductaionCountryGridControl.Countries = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Test
        {
            get => TestCountryGridControl.Countries;
            set => TestCountryGridControl.Countries = value;
        }

        public MainTab()
        {
            InitializeComponent();
        }

        private void ClassifierControl_ButtonClicked(object sender, EventArgs e)
        {
            IClassifier classifier;
            Stopwatch stopwatch = new Stopwatch();
            switch (ClassifierControl.ClassifierType)
            {
                case ClassifierType.LinearClassifier: classifier = new LinearClassifier(); break;
                case ClassifierType.NeighborClassifier: classifier = new
                        NeighborClassifier(ClassifierControl.NeighborsCount); break;
                default: throw new ArgumentException();
            }
            stopwatch.Start();
            classifier.Educate(EductaionCountryGridControl.Countries);
            stopwatch.Stop();
            ResultForm form = new ResultForm();
            form.Time = stopwatch.Elapsed;
            form.ClassifierName = classifier.ToString();
            stopwatch.Start();
            form.Countries = classifier.Classify(TestCountryGridControl.Countries);
            stopwatch.Stop();
            form.Time += stopwatch.Elapsed;
            form.Scene3D = SceneFactory.CreateScene3DByClassifier(classifier);
            form.Show();
        }
    }
}