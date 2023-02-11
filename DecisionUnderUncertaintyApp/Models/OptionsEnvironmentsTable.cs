namespace DecisionUnderUncertaintyApp.Models
{
    public class OptionsEnvironmentsTable
    {
        private bool _isLossTable = false;

        private double[,] _tableMatrix = new double[0, 0];

        public bool IsLossTable
        {
            get => _isLossTable;
            set => _isLossTable = value;
        }

        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set => _tableMatrix = value;
        }

        public OptionsEnvironmentsTable() {}

        public OptionsEnvironmentsTable(bool isLossTable, double[,] tableMatrix)
        {
            IsLossTable = isLossTable;
            TableMatrix = tableMatrix;
        }
    }
}