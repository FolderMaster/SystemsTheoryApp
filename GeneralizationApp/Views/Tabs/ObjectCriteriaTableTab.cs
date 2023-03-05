using System;
using System.ComponentModel;
using System.Windows.Forms;

using GeneralizationApp.Views.Controls;
using GeneralizationApp.Models;
using GeneralizationApp.Views.Forms;
using GeneralizationApp.Services.Rollupers;
using System.Diagnostics;

namespace GeneralizationApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для работы с таблицей оценок альтернатив.
    /// </summary>
    public partial class ObjectCriteriaTableTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт таблицу оценок альтернатив.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ObjectCriteriaTable ObjectCriteriaRollupTable
        {
            get => ObjectCriteriaTableControl.ObjectCriteriaRollupTable;
            set => ObjectCriteriaTableControl.ObjectCriteriaRollupTable = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ObjectCriteriaTableTab"/> по умолчанию.
        /// </summary>
        public ObjectCriteriaTableTab()
        {
            InitializeComponent();
        }

        private void RolluperControl_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                int[] result;
                Stopwatch stopwatch = new Stopwatch();
                switch (RolluperControl.RolluperType)
                {
                    case RolluperType.AdditiveRolluper:
                        stopwatch.Start();
                        result = ObjectCriteriaTableRolluper.
                            AdditiveRollup(ObjectCriteriaRollupTable);
                        stopwatch.Stop();
                        break;
                    case RolluperType.MultiplicativeRolluper:
                        stopwatch.Start();
                        result = ObjectCriteriaTableRolluper.
                            MultiplicativeRollup(ObjectCriteriaRollupTable);
                        stopwatch.Stop();
                        break;
                    case RolluperType.IdealPointRolluper:
                        stopwatch.Start();
                        result = ObjectCriteriaTableRolluper.
                            IdealPointRollup(ObjectCriteriaRollupTable);
                        stopwatch.Stop();
                        break;
                    default: throw new ArgumentException();
                }
                string generalizerName = RolluperControl.RolluperType.ToString();
                ResultForm resultForm = new ResultForm();
                resultForm.GeneralizerName = generalizerName;
                resultForm.Result = result;
                resultForm.Time = stopwatch.Elapsed;
                resultForm.Show();
            }
            catch(Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}