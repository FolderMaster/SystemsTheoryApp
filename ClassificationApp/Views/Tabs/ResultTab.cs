using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassificationApp.Models.Countries;
using ClassificationApp.Models.Scenes;
using ClassificationApp.Views.Controls;

namespace ClassificationApp.Views.Tabs
{
    public partial class ResultTab : UserControl
    {
        public List<Country> Result
        {
            set
            {
                CountryGridControl.Countries = value;
            }
        }

        public Scene3D Scene3D
        {
            set
            {
                Scene3DDisplayControl.Scene3D = value;
            }
        }

        public ResultTab()
        {
            InitializeComponent();
        }
    }
}