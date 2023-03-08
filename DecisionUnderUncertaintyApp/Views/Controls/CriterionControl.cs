using System;
using System.ComponentModel;
using System.Windows.Forms;

using DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion;
using DecisionUnderUncertaintyApp.Services.Validators;

namespace DecisionUnderUncertaintyApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для выбора критерия нахождения оптимального решения.
    /// </summary>
    public partial class CriterionControl : UserControl
    {
        /// <summary>
        /// Интерфейс критерия нахождения оптимального решения.
        /// </summary>
        private IDecissionSearchСriterion _iDecissionSearchСriterion = null;

        /// <summary>
        /// Коэффициент Гурвица.
        /// </summary>
        private double _coefficient;

        /// <summary>
        /// Возращает и задаёт интерфейс критерия нахождения оптимального решения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IDecissionSearchСriterion IDecissionSearchСriterion
        {
            get => _iDecissionSearchСriterion;
            private set => _iDecissionSearchСriterion = value;
        }

        /// <summary>
        /// Возращает и задаёт коэффициент Гурвица. Должен быть от 0 до 1.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private double Coefficient
        {
            get => _coefficient;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 1, nameof(Coefficient));
                _coefficient = value;
            }
        }

        /// <summary>
        /// Задаёт выбранного типа критерия нахождения оптимального решения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private СriterionType СriterionType
        {
            get => CriterionTypeSelectorControl.SelectedItem;
        }

        /// <summary>
        /// Обработчик событий нажатия кнопки.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CriterionControl"/> по умолчанию.
        /// </summary>
        public CriterionControl()
        {
            InitializeComponent();
        }

        private void CoefficientTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Coefficient = double.Parse(CoefficientTextBox.Text);
                CoefficientTextBox.BackColor = ColorManager.CorrectColor;
            }
            catch
            {
                CoefficientTextBox.BackColor = ColorManager.ErrorColor;
            }
        }

        private void CriterionTypeSelectorControl_SelectedItemChanged(object sender, EventArgs e)
        {
            switch(СriterionType)
            {
                case СriterionType.HurwitzCriterion: CoefficientPanel.Visible = true; break;
                default: CoefficientPanel.Visible = false; break;
            }
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            switch (СriterionType)
            {
                case СriterionType.LaplaceCriterion: IDecissionSearchСriterion = new
                        LaplaceCriterion(); break;
                case СriterionType.WaldCriterion: IDecissionSearchСriterion= new WaldCriterion();
                    break;
                case СriterionType.HurwitzCriterion: IDecissionSearchСriterion = new
                        HurwitzCriterion(Coefficient); break;
                case СriterionType.MaximumCriterion: IDecissionSearchСriterion = new
                        MaximumCriterion(); break;
                case СriterionType.SavageCriterion: IDecissionSearchСriterion = new
                        SavageCriterion(); break;
                default: IDecissionSearchСriterion = null; break;
            }
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}