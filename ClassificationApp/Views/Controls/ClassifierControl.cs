using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificationApp.Views.Controls
{
    public partial class ClassifierControl : UserControl
    {
        public ClassifierType ClassifierType
        {
            get
            {
                return (ClassifierType)ComboBox.SelectedItem;
            }
        }

        public int NeighborsCount
        {
            get
            {
                return (int)NeighborsCountNumericUpDown.Value;
            }
        }

        public event EventHandler ButtonClicked;

        public ClassifierControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(ClassifierType));
        }

        private void ClassifyButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ClassifierType)
            {
                case ClassifierType.LinearClassifier: NeighborsCountLabel.Visible = false;
                    NeighborsCountNumericUpDown.Visible = false; break;
                case ClassifierType.NeighborClassifier: NeighborsCountLabel.Visible = true;
                    NeighborsCountNumericUpDown.Visible = true; break;
                default: throw new ArgumentException();
            }
        }
    }
}