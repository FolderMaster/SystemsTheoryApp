using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс трёхмерного графика.
    /// </summary>
    public class Graph3D : IGraph
    {
        /// <summary>
        /// Количество осей.
        /// </summary>
        private const int count = 3;

        /// <summary>
        /// Массив осей.
        /// </summary>
        private Axis[] _axises = new Axis[count];

        public List<Axis> Axises
        {
            get => _axises.ToList();
        }

        /// <summary>
        /// Возращает и задаёт список трёх осей. Должно быть 3 оси.
        /// </summary>
        public List<Axis> Axises3D
        {
            get => _axises.ToList();
            set
            {
                if(value.Count != count)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _axises = value.ToArray();
                }
            }
        }

        public List<IShape> Shapes { get; set; } = new List<IShape>();

        public List<IShape> Displays
        {
            get
            {
                List<IShape> result = new List<IShape>();
                foreach (IShape shape in Shapes)
                {
                    result.Add(shape.Display(this));
                }
                return result;
            }
        }

        public ICamera DefaultCamera
        {
            get
            {
                Camera3D result = new Camera3D();
                return result;
            }
        }

        public double DefaultValue { get; set; } = 0;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Graph3D"/> по умолчанию.
        /// </summary>
        public Graph3D()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Graph3D"/>.
        /// </summary>
        /// <param name="axises3D">Список трёх осей.</param>
        /// <param name="defaultValue">Значение по умолчанию.</param>
        public Graph3D(List<Axis> axises3D, double defaultValue = 0)
        {
            Axises3D = axises3D;
            DefaultValue = defaultValue;
        }

        /// <summary>
        /// Находит минимальную координату на оси.
        /// </summary>
        /// <param name="axisesIndex">Индекс оси.</param>
        /// <returns>Минимальная координата.</returns>
        /// <exception cref="ArgumentException"></exception>
        public double GetMin(int axisesIndex)
        {
            if(axisesIndex >= Axises3D.Count)
            {
                throw new ArgumentException();
            }
            else
            {
                if (Shapes.Count == 0)
                {
                    return DefaultValue;
                }
                else
                {
                    List<double> coordinates = new List<double>();
                    foreach (IShape shape in Shapes)
                    {
                        coordinates.Add(shape.GetMin(this, axisesIndex));
                    }
                    return coordinates.Min();
                }
            }
        }

        /// <summary>
        /// Находит максимальную координату на оси.
        /// </summary>
        /// <param name="axisesIndex">Индекс оси.</param>
        /// <returns>Максимальная координата.</returns>
        /// <exception cref="ArgumentException"></exception>
        public double GetMax(int axisesIndex)
        {
            if (axisesIndex >= Axises3D.Count)
            {
                throw new ArgumentException();
            }
            else
            {
                if (Shapes.Count == 0)
                {
                    return DefaultValue;
                }
                else
                {
                    List<double> coordinates = new List<double>();
                    foreach (IShape shape in Shapes)
                    {
                        coordinates.Add(shape.GetMax(this, axisesIndex));
                    }
                    return coordinates.Max();
                }
            }
        }

        /// <summary>
        /// Делает отображение по умолчанию.
        /// </summary>
        public void DefaultDisplay()
        {
            for (int n = 0; n < Axises3D.Count; ++n)
            {
                Axis axis = Axises3D[n];

                axis.Max = axis.MaxFunction(GetMax(n));

                axis.Min = axis.MinFunction(GetMin(n));
            }
        }
    }
}