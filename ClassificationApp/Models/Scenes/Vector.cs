using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// КЛасс вектора с координатами.
    /// </summary>
    public class Vector : IShape
    {
        public object Tag { get; set; } = null;

        /// <summary>
        /// Возращает и задаёт координаты.
        /// </summary>
        public List<double> Coordinates { get; set; } = new List<double>();

        /// <summary>
        /// Возращает количество осей.
        /// </summary>
        public int AxisCount
        {
            get => Coordinates.Count;
        }

        /// <summary>
        /// Возращает модуль.
        /// </summary>
        public double Abs
        {
            get
            {
                double result = 0;
                foreach (double value in Coordinates)
                {
                    result += Math.Pow(value, 2);
                }
                return Math.Sqrt(result);
            }
        }

        /// <summary>
        /// Возращает орт.
        /// </summary>
        public Vector Ort
        {
            get
            {
                List<double> coordinates = new List<double>();
                double abs = Abs;
                for(int n = 0; n < AxisCount; n++)
                {
                    coordinates.Add(this[n] / abs);
                }
                return new Vector(Tag, coordinates);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vector"/> по умолчанию.
        /// </summary>
        public Vector()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vector"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        public Vector(object tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vector"/>.
        /// </summary>
        /// <param name="coordinates"></param>
        public Vector(List<double> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Vector"/>.
        /// </summary>
        /// <param name="tag">Тег.</param>
        /// <param name="coordinates"></param>
        public Vector(object tag, List<double> coordinates)
        {
            Tag = tag;
            Coordinates = coordinates;
        }

        /// <summary>
        /// Возращает и задаёт координату.
        /// </summary>
        /// <param name="index">Индекс оси.</param>
        /// <returns>Координата по индексу оси.</returns>
        public double this[int index]
        {
            get => Coordinates[index];
            set => Coordinates[index] = value;
        }

        public IShape Display(IGraph schedule)
        {
            return new Vector(Tag, Coordinates);
        }

        public double GetMax(IGraph schedule, int axisIndex)
        {
            throw new System.NotImplementedException();
        }

        public double GetMin(IGraph schedule, int axisIndex)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Разворачивает на угол вектор по оси OX.
        /// </summary>
        /// <param name="angle">Угол.</param>
        /// <returns>Развёрнутый вектор.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Vector RotateByAngleOx(double angle)
        {
            if (AxisCount != 3)
            {
                throw new InvalidOperationException();
            }
            else
            {
                double x = this[0];
                double y = this[1];
                double z = this[2];

                List<double> coordinates = new List<double>
                {
                    x,
                    y * Math.Cos(angle) + z * Math.Sin(angle),
                    -y * Math.Sin(angle) + z * Math.Cos(angle)
                };
                return new Vector(coordinates);
            }
        }

        /// <summary>
        /// Разворачивает на угол вектор по оси OY.
        /// </summary>
        /// <param name="angle">Угол.</param>
        /// <returns>Развёрнутый вектор.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Vector RotateByAngleOy(double angle)
        {
            if (AxisCount != 3)
            {
                throw new InvalidOperationException();
            }
            else
            {
                double x = this[0];
                double y = this[1];
                double z = this[2];

                List<double> coordinates = new List<double>
                {
                    x * Math.Cos(angle) + z * Math.Sin(angle),
                    y,
                    -x * Math.Sin(angle) + z * Math.Cos(angle)
                };
                return new Vector(coordinates);
            }
        }

        /// <summary>
        /// Рассчитывает угол между осью и вектором.
        /// </summary>
        /// <param name="axisIndex">Индекс оси.</param>
        /// <returns>Угол между осью и вектором.</returns>
        public double GetAngle(int axisIndex)
        {
            return Math.Acos(this[axisIndex] / Abs);
        }

        /// <summary>
        /// Умножает значение на координаты векторами.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="vector">Вектор.</param>
        /// <returns>Вектор после умножения.</returns>
        public static Vector operator*(double value, Vector vector)
        {
            List<double> coordinates = new List<double>();
            foreach(double coordinate in vector.Coordinates)
            {
                coordinates.Add(coordinate * value);
            }
            return new Vector(vector.Tag, coordinates);
        }

        /// <summary>
        /// Вычитает координаты между векторами.
        /// </summary>
        /// <param name="vector1">Первый вектор.</param>
        /// <param name="vector2">Второй вектор.</param>
        /// <returns>Вектор разницы между векторами.</returns>
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < vector1.AxisCount && n < vector2.AxisCount; ++n)
            {
                coordinates.Add(vector1[n] - vector2[n]);
            }
            return new Vector(coordinates);
        }

        /// <summary>
        /// Рассчитывает характер угла между векторами.
        /// </summary>
        /// <param name="vector1">Первый вектор.</param>
        /// <param name="vector2">Второй вектор.</param>
        /// <returns>Если значение меньше нуля, угол тупой, если значение равно нулю, то угол прямой,
        /// а, если значение больше, то угол острый.</returns>
        public static double CharacterOfAngleBetweenVectors(Vector vector1, Vector vector2)
        {
            double result = 0;
            for(int n = 0; n < vector1.AxisCount && n < vector2.AxisCount; ++n)
            {
                result += vector1[n] * vector2[n];
            }
            return result;
        }

        /// <summary>
        /// Рассчитывает косинус угла между векторами.
        /// </summary>
        /// <param name="vector1">Первый вектор.</param>
        /// <param name="vector2">Второй вектор.</param>
        /// <returns>Косинус угла между векторами.</returns>
        public static double CosAngleBetweenVectors(Vector vector1, Vector vector2)
        {
            return CharacterOfAngleBetweenVectors(vector1, vector2) / (vector1.Abs + vector2.Abs);
        }
    }
}