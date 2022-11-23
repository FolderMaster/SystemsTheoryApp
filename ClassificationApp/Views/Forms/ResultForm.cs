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

namespace ClassificationApp.Views.Forms
{
    public partial class ResultForm : Form
    {
        public List<Country> Countries
        {
            set
            {
                ResultTab.Result = value;
            }
        }

        public Scene3D Scene3D
        {
            set
            {
                ResultTab.Scene3D = value;
            }
        }

        public ResultForm()
        {
            InitializeComponent();
        }
    }
}