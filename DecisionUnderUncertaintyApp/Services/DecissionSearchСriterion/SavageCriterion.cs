using DecisionUnderUncertaintyApp.Models;
using DecisionUnderUncertaintyApp.Services.Managers;
using DecisionUnderUncertaintyApp.Services.Validators;

namespace DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion
{
    public class SavageCriterion : IDecissionSearchСriterion
    {
        public double[] EvaluateDecissions(OptionsEnvironmentsTable table)
        {
            double[,] matrixTable = table.TableMatrix;
            ValueValidator.AssertMatrixIsNotNull(matrixTable, nameof(matrixTable));
            int environmentsCount = matrixTable.GetLength(1);
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

            double[,] newTable = new double[optionsCount, environmentsCount];
            for (int y = 0; y < optionsCount; ++y)
            {
                for (int x = 0; x < environmentsCount; ++x)
                {
                    newTable[y, x] = MatrixManager.GetColumnMax(newMatrix, x) -
                        newMatrix[y, x];
                }
            }

            double[] result = new double[optionsCount];
            for (int y = 0; y < optionsCount; ++y)
            {
                result[y] = MatrixManager.GetRowMax(newTable, y);
            }
            return result;
        }

        public int SearchBestDecission(double[] array) => MatrixManager.GetMinIndex(array);
    }
}