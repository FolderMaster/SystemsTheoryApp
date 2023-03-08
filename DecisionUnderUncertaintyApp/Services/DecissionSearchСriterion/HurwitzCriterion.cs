using DecisionUnderUncertaintyApp.Models;
using DecisionUnderUncertaintyApp.Services.Managers;
using DecisionUnderUncertaintyApp.Services.Validators;

namespace DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion
{
    /// <summary>
    /// Критерий нахождения наиболее оптимального решения Гурвица.
    /// </summary>
    public class HurwitzCriterion : IDecissionSearchСriterion
    {
        /// <summary>
        /// Коэффициент.
        /// </summary>
        private double _coefficient;

        /// <summary>
        /// Возаращает и задаёт коэффициент. Должен быть от 0 до 1.
        /// </summary>
        public double Coefficient
        {
            get => _coefficient;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 1, nameof(Coefficient));
                _coefficient = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="HurwitzCriterion"/>.
        /// </summary>
        /// <param name="coefficient">Коэффициент.</param>
        public HurwitzCriterion(double coefficient)
        {
            Coefficient = coefficient;
        }

        public double[] EvaluateDecissions(OptionsEnvironmentsTable table)
        {
            double[,] matrixTable = table.TableMatrix;
            ValueValidator.AssertMatrixIsNotNull(matrixTable, nameof(matrixTable));
            int optionsCount = matrixTable.GetLength(0);
            double[,] newMatrix;
            if (table.IsLossTable)
            {
                newMatrix = MatrixManager.MultiplyMatrixByNumber(matrixTable, -1);
            }
            else
            {
                newMatrix = matrixTable;
            }

            double[] result = new double[optionsCount];
            for (int y = 0; y < optionsCount; ++y)
            {
                result[y] = Coefficient * MatrixManager.GetRowMax(newMatrix, y) +
                    (1 - Coefficient) * MatrixManager.GetRowMin(newMatrix, y);
            }
            return result;
        }

        public int SearchBestDecission(double[] array) => MatrixManager.GetMaxIndex(array);
    }
}