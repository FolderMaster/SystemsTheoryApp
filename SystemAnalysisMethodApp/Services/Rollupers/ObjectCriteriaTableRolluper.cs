using SystemAnalysisMethodApp.Models;

namespace SystemAnalysisMethodApp.Services.Rollupers
{
    public static class ObjectCriteriaTableRolluper
    {
        public static double[] AdditiveRollup(ObjectCriteriaTable table)
        {
            int objectCount = table.TableMatrix.GetLength(0);
            int criteriaCount = table.TableMatrix.GetLength(1);

            double[] result = new double[objectCount];
            if (table.WeightMatrix == null)
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        result[y] += table.TableMatrix[y, x];
                    }
                    result[y] /= criteriaCount;
                }
            }
            else
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        result[y] += table.TableMatrix[y, x] * table.WeightMatrix[x];
                    }
                }
            }

            return result;
        }
    }
}