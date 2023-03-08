namespace DecisionUnderUncertaintyApp.Models
{
    /// <summary>
    /// Класс таблицы вариантов и состояний среды c матрицей таблицы и логическим значением,
    /// указывающее, тявляется ли таблица таблицей убытков.
    /// </summary>
    public class OptionsEnvironmentsTable
    {
        /// <summary>
        /// Логическое значение, указывающее, тявляется ли таблица таблицей убытков.
        /// </summary>
        private bool _isLossTable = false;

        /// <summary>
        /// Матрица таблицы.
        /// </summary>
        private double[,] _tableMatrix = new double[0, 0];

        /// <summary>
        /// Возращает и задаёт логическое значение, указывающее, тявляется ли таблица таблицей
        /// убытков.
        /// </summary>
        public bool IsLossTable
        {
            get => _isLossTable;
            set => _isLossTable = value;
        }

        /// <summary>
        /// Возращает и задаёт матрица таблицы.
        /// </summary>
        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set => _tableMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OptionsEnvironmentsTable"/> по умолчанию.
        /// </summary>
        public OptionsEnvironmentsTable() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OptionsEnvironmentsTable"/>.
        /// </summary>
        /// <param name="isLossTable">Логическое значение, указывающее, тявляется ли таблица
        /// таблицей убытков.</param>
        /// <param name="tableMatrix">Матрица таблицы.</param>
        public OptionsEnvironmentsTable(bool isLossTable, double[,] tableMatrix)
        {
            IsLossTable = isLossTable;
            TableMatrix = tableMatrix;
        }
    }
}