using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Forms
{
    public partial class ResultForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[] Result
        {
            get => ResultTab.Result;
            set => ResultTab.Result = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GeneralizerName
        {
            get => ResultTab.GeneralizerName;
            set => ResultTab.GeneralizerName = value;
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