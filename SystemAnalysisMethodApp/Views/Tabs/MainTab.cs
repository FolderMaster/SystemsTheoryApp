using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Views.Tabs
{
    public partial class MainTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Country> Countries
        {
            get => CountryGridControl.Countries;
            set => CountryGridControl.Countries = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PairComparisonMatrix PairComparisonMatrix
        {
            get => PairComparisonMatrixControl.PairComparisonMatrix;
            set => PairComparisonMatrixControl.PairComparisonMatrix = value;
        }

        public MainTab()
        {
            InitializeComponent();
            PairComparisonMatrixControl.Names = new string[6]
            {
                nameof(Country.AverageLivingCost),
                nameof(Country.TripPrice),
                nameof(Country.AttractionCount),
                nameof(Country.Climate),
                nameof(Country.DevelopmentLevel),
                nameof(Country.TouristPopularity)
            };
        }
    }
}
