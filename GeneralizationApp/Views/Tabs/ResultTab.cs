using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Tabs
{
    public partial class ResultTab : UserControl
    {
        private const string _resultString = "The result received by ";

        private const string _withinString = " within ";

        private string _generalizerName = null;

        private TimeSpan _time = new TimeSpan();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[] Result
        {
            get
            {
                int[] result = new int[ValueTableGridControl.TableMatrix.Length];
                for (int n = 0; n < result.Length; ++n)
                {
                    result[n] = (int)ValueTableGridControl.TableMatrix[n] - 1;
                }
                return result;
            }
            set
            {
                double[] result = new double[value.Length];
                for(int n = 0; n < result.Length; ++n)
                {
                    result[n] = ++value[n];
                }
                ValueTableGridControl.TableMatrix = result;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GeneralizerName
        {
            get => _generalizerName;
            set
            {
                _generalizerName = value;
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
            ResultLabel.Text = _resultString + GeneralizerName + _withinString + Time;
        }
    }
}