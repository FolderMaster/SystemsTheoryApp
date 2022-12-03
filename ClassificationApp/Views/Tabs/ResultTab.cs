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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Result
        {
            set
            {
                CountryGridControl.Countries = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            set
            {
                Scene3DDisplayControl.Scene3D = value;
            }
        }

        public string ClassifierName
        {
            set
            {
                TextLabel.Text = value;
            }
        }

        public ResultTab()
        {
            InitializeComponent();
        }
    }
}