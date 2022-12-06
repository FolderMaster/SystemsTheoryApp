using System.ComponentModel;
using System.Windows.Forms;
using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    public partial class FinalResultForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ObjectCriteriaTable ObjectCriteriaTable
        {
            set => FinalResultTab.ObjectCriteriaTable = value;
        }

        public FinalResultForm()
        {
            InitializeComponent();
        }
    }
}