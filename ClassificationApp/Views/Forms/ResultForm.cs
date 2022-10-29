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

namespace ClassificationApp.Views.Forms
{
    public partial class ResultForm : Form
    {
        public List<Country> Countries
        {
            set
            {
                CountryGridControl.Countries = value;
            }
        }

        public ResultForm()
        {
            InitializeComponent();
        }
    }
}
