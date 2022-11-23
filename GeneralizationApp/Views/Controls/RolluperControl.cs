using System;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class RolluperControl : UserControl
    {
        public RolluperType RolluperType
        {
            get => (RolluperType)ComboBox.SelectedItem;
        }

        public event EventHandler ButtonClicked;

        public RolluperControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(RolluperType));
        }

        private void RollupButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}