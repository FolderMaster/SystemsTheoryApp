using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class RankingExpertRatingTableControl : UserControl
    {
        private int _expertCount = 1;

        private int _objectCount = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[,] TableMatrix
        {
            get => RankingExpertRatingTableGridControl.TableMatrix;
            set => RankingExpertRatingTableGridControl.TableMatrix = value;
        }

        public RankingExpertRatingTableControl()
        {
            InitializeComponent();
        }

        private void ExpertCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _expertCount = (int)ExpertCountNumericUpDown.Value;
        }

        private void ObjectCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _objectCount = (int)ObjectCountNumericUpDown.Value;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TableMatrix = new int[_expertCount, _objectCount]; 
        }
    }
}