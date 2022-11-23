using System;
using System.Windows.Forms;

namespace GeneralizationApp.Views.Controls
{
    public partial class RankingGeneralizerControl : UserControl
    {
        public RankingGeneralizerType GeneralizationType
        {
            get => (RankingGeneralizerType)ComboBox.SelectedItem;
        }

        public event EventHandler ButtonClicked;

        public RankingGeneralizerControl()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(RankingGeneralizerType));
        }

        private void GeneralizeButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}