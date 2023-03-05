using System.Linq;

using GeneralizationApp.Models;

namespace GeneralizationApp.Services.Generalizaters
{
    /// <summary>
    /// Класс обобщения таблиц ранговой оценки экспертов, предоставляющий методы.
    /// </summary>
    public static class RankingExpertRatingTableGeneralizer
    {
        /// <summary>
        /// Обобщает таблицу ранговой оценки экспертов методом ранжирования.
        /// </summary>
        /// <param name="table">Таблица ранговой оценки экспертов.</param>
        /// <returns>Масссив с оценками.</returns>
        public static int[] RangingGeneralize(RankingExpertRatingTable table)
        {
            int expertCount = table.TableMatrix.GetLength(0);
            int objectCount = table.TableMatrix.GetLength(1);

            (int, int)[] valueSum = new (int, int)[objectCount];
            for (int x = 0; x < objectCount; ++x)
            {
                valueSum[x].Item2 = x;
                for (int y = 0; y < expertCount; ++y)
                {
                    valueSum[x].Item1 += table.TableMatrix[y, x];
                }
                valueSum[x].Item1 /= expertCount;
            }

            return valueSum.OrderBy(a => a.Item1).Select(a => a.Item2).ToArray();
        }

        /// <summary>
        /// Обобщает таблицу ранговой оценки экспертов методом парного сравнения.
        /// </summary>
        /// <param name="table">Таблица ранговой оценки экспертов.</param>
        /// <returns>Масссив с оценками.</returns>
        public static int[] PairComparisonGeneralize(RankingExpertRatingTable table)
        {
            int expertCount = table.TableMatrix.GetLength(0);
            int objectCount = table.TableMatrix.GetLength(1);

            bool[,,] expertMatrixes = new bool[expertCount, objectCount, objectCount];
            for(int z = 0; z < expertCount; ++z)
            {
                for(int y = 0; y < objectCount; ++y)
                {
                    for(int x = 0; x < objectCount; ++x)
                    {
                        if (table.TableMatrix[z, y] <= table.TableMatrix[z, x])
                        {
                            expertMatrixes[z, y, x] = true;
                        }
                    }
                }
            }

            bool[,] generalMatrix = new bool[objectCount, objectCount];
            for(int y = 0; y < objectCount; ++y)
            {
                for(int x = 0; x < objectCount; ++x)
                {
                    int trueCount = 0;
                    for(int z = 0; z < expertCount; ++z)
                    {
                        if (expertMatrixes[z, y, x])
                        {
                            ++trueCount;
                        }
                    }
                    if (trueCount >= expertCount / (double)2)
                    {
                        generalMatrix[y, x] = true;
                    }
                }
            }

            (int, int)[] valueSum = new (int, int)[objectCount];
            for(int y = 0; y < objectCount; ++y)
            {
                valueSum[y].Item2 = y;
                for(int x = 0; x < objectCount; ++x)
                {
                    if (generalMatrix[y, x])
                    {
                        ++valueSum[y].Item1;
                    }
                }
            }

            return valueSum.OrderByDescending(a => a.Item1).Select(a => a.Item2).ToArray();
        }
    }
}