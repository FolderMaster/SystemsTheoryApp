﻿using System;
using System.Linq;

using GeneralizationApp.Models;

namespace GeneralizationApp.Services.Rollupers
{
    /// <summary>
    /// Класс свёртки таблиц оценок альтернатив, предоставляющий методы.
    /// </summary>
    public static class ObjectCriteriaTableRolluper
    {
        /// <summary>
        /// Обобщает таблицу оценок альтернатив методом аддитивной свёртки.
        /// </summary>
        /// <param name="table">Таблица оценок альтернатив.</param>
        /// <returns>Масссив с оценками.</returns>
        public static int[] AdditiveRollup(ObjectCriteriaTable table)
        {
            int objectCount = table.TableMatrix.GetLength(0);
            int criteriaCount = table.TableMatrix.GetLength(1);
            double[,] newTable = Normalize(table.TableMatrix, table.DecreasingMatrix);

            (double, int)[] valueSum = new (double, int)[objectCount];
            if (table.WeightMatrix == null)
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 += newTable[y, x];
                    }
                    valueSum[y].Item1 /= criteriaCount;
                }
            }
            else
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 += newTable[y, x] * table.WeightMatrix[x];
                    }
                }
            }

            return valueSum.OrderByDescending(a => a.Item1).Select(a => a.Item2).ToArray();
        }

        /// <summary>
        /// Обобщает таблицу оценок альтернатив методом мультипликативной свёртки.
        /// </summary>
        /// <param name="table">Таблица оценок альтернатив.</param>
        /// <returns>Масссив с оценками.</returns>
        public static int[] MultiplicativeRollup(ObjectCriteriaTable table)
        {
            int objectCount = table.TableMatrix.GetLength(0);
            int criteriaCount = table.TableMatrix.GetLength(1);
            double[,] newTable = Normalize(table.TableMatrix, table.DecreasingMatrix);

            (double, int)[] valueSum = new (double, int)[objectCount];
            if (table.WeightMatrix == null)
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    valueSum[y].Item1 = 1;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 *= newTable[y, x];
                    }
                    valueSum[y].Item1 = Math.Pow(valueSum[y].Item1, 1 / (double)criteriaCount);
                }
            }
            else
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    valueSum[y].Item1 = 1;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 *= Math.Pow(newTable[y, x], table.WeightMatrix[x]);
                    }
                }
            }

            return valueSum.OrderByDescending(a => a.Item1).Select(a => a.Item2).ToArray();
        }

        /// <summary>
        /// Обобщает таблицу оценок альтернатив методом идеальной точки.
        /// </summary>
        /// <param name="table">Таблица оценок альтернатив.</param>
        /// <returns>Масссив с оценками.</returns>
        public static int[] IdealPointRollup(ObjectCriteriaTable table)
        {
            int objectCount = table.TableMatrix.GetLength(0);
            int criteriaCount = table.TableMatrix.GetLength(1);
            double[,] newTable = Normalize(table.TableMatrix, table.DecreasingMatrix);

            double[] idealPoint = new double[criteriaCount];
            for (int n = 0; n < criteriaCount; ++n)
            {
                idealPoint[n] = 1;
            }

            (double, int)[] valueSum = new (double, int)[objectCount];
            if (table.WeightMatrix == null)
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 += Math.Pow(idealPoint[x] - newTable[y, x], 2);
                    }
                    valueSum[y].Item1 /= criteriaCount;
                    valueSum[y].Item1 = Math.Sqrt(valueSum[y].Item1);
                }
            }
            else
            {
                for (int y = 0; y < objectCount; ++y)
                {
                    valueSum[y].Item2 = y;
                    for (int x = 0; x < criteriaCount; ++x)
                    {
                        valueSum[y].Item1 += table.WeightMatrix[x] * Math.Pow(idealPoint[x] - 
                            newTable[y, x], 2);
                    }
                    valueSum[y].Item1 = Math.Sqrt(valueSum[y].Item1);
                }
            }

            return valueSum.OrderBy(a => a.Item1).Select(a => a.Item2).ToArray();
        }

        /// <summary>
        /// Нормализует матрицу таблицы.
        /// </summary>
        /// <param name="table">Матрица таблицы.</param>
        /// <param name="signs">Массив флагов.</param>
        /// <returns>Нормализованная матрица таблицы.</returns>
        private static double[,] Normalize(double[,] table, bool[] signs)
        {
            int objectCount = table.GetLength(0);
            int criteriaCount = table.GetLength(1);

            double[,] result = new double[objectCount, criteriaCount];
            for(int x = 0; x < criteriaCount; ++x)
            {
                double min = GetMin(table, x);
                double max = GetMax(table, x);
                if (signs[x])
                {
                    for (int y = 0; y < objectCount; ++y)
                    {
                        result[y, x] = (max - table[y, x]) / (max - min);
                    }
                }
                else
                {
                    for (int y = 0; y < objectCount; ++y)
                    {
                        result[y, x] = (table[y, x] - min) / (max - min);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Находит максимум в матрице таблицы по критерию.
        /// </summary>
        /// <param name="table">Матрица таблицы.</param>
        /// <param name="criteriaIndex">Индекс критерия.</param>
        /// <returns>Максимум по критерию.</returns>
        private static double GetMax(double[,] table, int criteriaIndex)
        {
            int objectCount = table.GetLength(0);

            double max = table[0, criteriaIndex];
            for (int y = 1; y < objectCount; ++y)
            {
                if(max < table[y, criteriaIndex])
                {
                    max = table[y, criteriaIndex];
                }
            }

            return max;
        }

        /// <summary>
        /// Находит минимум в матрице таблицы по критерию.
        /// </summary>
        /// <param name="table">Матрица таблицы.</param>
        /// <param name="criteriaIndex">Индекс критерия.</param>
        /// <returns>Минимум по критерию.</returns>
        private static double GetMin(double[,] table, int criteriaIndex)
        {
            int objectCount = table.GetLength(0);

            double min = table[0, criteriaIndex];
            for (int y = 1; y < objectCount; ++y)
            {
                if (min > table[y, criteriaIndex])
                {
                    min = table[y, criteriaIndex];
                }
            }

            return min;
        }
    }
}