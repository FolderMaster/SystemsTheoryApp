using System.Linq;

using GeneralizationApp.Models;

namespace GeneralizationApp.Services.Generalizaters
{
    public static class ScoringExpertRatingTableGeneralizer
    {
        public static int[] Generalize(ScoringExpertRatingTable table)
        {
            int expertCount = table.TableMatrix.GetLength(0);
            int objectCount = table.TableMatrix.GetLength(1);

            (double, int)[] valueSum = new (double, int)[objectCount];
            if (table.CompetenceMatrix == null)
            {
                for (int x = 0; x < objectCount; ++x)
                {
                    valueSum[x].Item2 = x;
                    for (int y = 0; y < expertCount; ++y)
                    {
                        valueSum[x].Item1 += table.TableMatrix[y, x];
                    }
                    valueSum[x].Item1 /= expertCount;
                }
            }
            else
            {
                for (int x = 0; x < objectCount; ++x)
                {
                    valueSum[x].Item2 = x;
                    for (int y = 0; y < expertCount; ++y)
                    {
                        valueSum[x].Item1 += table.CompetenceMatrix[y] * table.TableMatrix[y, x];
                    }
                }
            }

            return valueSum.OrderByDescending(a => a.Item1).Select(a => a.Item2).ToArray();
        }
    }
}