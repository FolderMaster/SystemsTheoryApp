using System.ComponentModel;
using System.Windows.Forms;
using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Forms
{
    /// <summary>
    /// Окно отображения финального результата.
    /// </summary>
    public partial class FinalResultForm : Form
    {
        /// <summary>
        /// Задаёт таблицу оценок альтернатив.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ObjectCriteriaTable ObjectCriteriaTable
        {
            set => FinalResultTab.ObjectCriteriaTable = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FinalResultForm"/> по умолчанию.
        /// </summary>
        public FinalResultForm()
        {
            InitializeComponent();
        }
    }
}