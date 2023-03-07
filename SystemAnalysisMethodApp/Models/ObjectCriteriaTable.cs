using SystemAnalysisMethodApp.Services.Validators;

namespace SystemAnalysisMethodApp.Models
{
    /// <summary>
    /// Класс таблицы оценок альтернатив с матрицей таблицы и массивом компетенций, массивом
    /// логических значений, которые отвечают, убывающий параметр или нет, названиями альтернатив,
    /// названиями критериев.
    /// </summary>
    public class ObjectCriteriaTable
    {
        /// <summary>
        /// Матрица таблицы.
        /// </summary>
        private double[,] _tableMatrix = null;

        /// <summary>
        /// Массив весов.
        /// </summary>
        private double[] _weightMatrix = null;

        /// <summary>
        /// Массив логических значений, которые отвечают, убывающий параметр или нет.
        /// </summary>
        private bool[] _decreasingMatrix = null;

        /// <summary>
        /// Названия альтернатив.
        /// </summary>
        private string[] _alternativeNames = null;

        /// <summary>
        /// Названия критериев.
        /// </summary>
        private string[] _criteriaNames = null;

        /// <summary>
        /// Возращает и задаёт названия альтернатив. Должно быть не пустое.
        /// </summary>
        public string[] AlternativeNames
        {
            get => _alternativeNames;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(AlternativeNames));
                _alternativeNames = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт названия критериев. Должно быть не пустое.
        /// </summary>
        public string[] CriteriaNames
        {
            get => _criteriaNames;
            set
            {
                ValueValidator.AssertIsNotNull(value, nameof(CriteriaNames));
                _criteriaNames = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт матрицу таблицы. Элементы должны быть положительными.
        /// </summary>
        public double[,] TableMatrix
        {
            get => _tableMatrix;
            set
            {
                ValueValidator.AssertMatrixIsPositive(value, nameof(TableMatrix));
                _tableMatrix = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт массив компетенций. Сумма элементов должна быть равна 1.
        /// </summary>
        public double[] WeightMatrix
        {
            get => _weightMatrix;
            set
            {
                if (value != null)
                {
                    ValueValidator.AssertMatrixSumIsEqualToOne(value, nameof(WeightMatrix));
                }
                _weightMatrix = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт массив логических значений, которые отвечают, убывающий параметр или
        /// нет.
        /// </summary>
        public bool[] DecreasingMatrix
        {
            get => _decreasingMatrix;
            set => _decreasingMatrix = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ObjectCriteriaTable"/> по умолчанию.
        /// </summary>
        public ObjectCriteriaTable()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ObjectCriteriaTable"/>.
        /// </summary>
        /// <param name="tableMatrix">Матрица таблицы.</param>
        /// <param name="weightMatrix">Массив компетенций.</param>
        /// <param name="decreasingMatrix">Массив логических значений, которые отвечают, убывающий
        /// параметр или нет.</param>
        public ObjectCriteriaTable(double[,] tableMatrix, double[] weightMatrix, bool[] 
            decreasingMatrix)
        {
            TableMatrix = tableMatrix;
            WeightMatrix = weightMatrix;
            DecreasingMatrix = decreasingMatrix;
        }
    }
}