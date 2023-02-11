using DecisionUnderUncertaintyApp.Models;
using DecisionUnderUncertaintyApp.Services.Managers;
using DecisionUnderUncertaintyApp.Services.Validators;

namespace DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion
{
    public class MaximumCriterion : IDecissionSearchСriterion
    {
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
                result[y] = MatrixManager.GetRowMax(newMatrix, y);
            }
            return result;
        }

        public int SearchBestDecission(double[] array) => MatrixManager.GetMaxIndex(array);
    }
}