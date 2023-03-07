using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;
using SystemAnalysisMethodApp.Views.Forms;
using SystemAnalysisMethodApp.Services.Factories;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    /// <summary>
    /// Элемент управления для начальных настроек рассчёта МАИ.
    /// </summary>
    public partial class MainTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список стран.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => CountryGridControl.Countries;
            set => CountryGridControl.Countries = value;
        }

        /// <summary>
        /// Возращает и задаёт матрицу парных сравнений критериев.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonMatrixControl.PairComparisonMatrix;
            set => PairComparisonMatrixControl.PairComparisonMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainTab"/> по умолчанию.
        /// </summary>
        public MainTab()
        {
            InitializeComponent();
        }

        private void UseMAHButton_Click(object sender, EventArgs e)
        {
            List<PairComparisonMatrix> pairComparisonMatrices = new List<PairComparisonMatrix>
            {
                PairComparisonMatrix
            };

            DialogResult dialogResult = DialogResult.None;
            for (int x = 0; x < PairComparisonMatrix.Count && dialogResult != DialogResult.Cancel;
                ++x)
            {
                PairComparisonForm form = new PairComparisonForm();
                form.Text = PairComparisonMatrix.Names[x] + form.Text;
                form.PairComparisonMatrix = PairComparisonMatrixFactory.
                    CreatePairComparisonMatrixByCountryCriteria(Countries, x);
                dialogResult = form.ShowDialog();
                pairComparisonMatrices.Add(form.PairComparisonMatrix);
            }
            if (dialogResult == DialogResult.OK)
            {
                FinalResultForm form = new FinalResultForm();
                form.ObjectCriteriaTable = 
                    ObjectCriteriaTableFactory.CreateObjectCriteriaTableByPairComparisonMatrix
                    (pairComparisonMatrices);
                form.ShowDialog();
            }
        }

        private void PairComparisonMatrixControl_PairComparisonMatrixChanged(object sender, 
            EventArgs e)
        {
            if(PairComparisonMatrixControl.IsRevisionNeeded)
            {
                UseMAHButton.Enabled = false;
            }
            else
            {
                UseMAHButton.Enabled = true;
            }
        }
    }
}