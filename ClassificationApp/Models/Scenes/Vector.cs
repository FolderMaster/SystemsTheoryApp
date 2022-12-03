using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    public class Vector : IShape
    {
        public object Tag { get; set; } = null;

        public List<double> Coordinates { get; set; } = new List<double>();

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

        public Vector Ort
        {
            get
            {
                List<double> coordinates = new List<double>();
                double abs = Abs;
                for(int n = 0; n < Coordinates.Count; n++)
                {
                    coordinates.Add(Coordinates[n] / abs);
                }
                return new Vector(Tag, coordinates);
            }
        }

        public Vector()
        {
        }

        public Vector(object tag)
        {
            Tag = tag;
        }

        public Vector(List<double> coordinates)
        {
            Coordinates = coordinates;
        }

        public Vector(object tag, List<double> coordinates)
        {
            Tag = tag;
            Coordinates = coordinates;
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

        public Vector RotateByAngleOx(double angle)
        {
            if (Coordinates.Count != 3)
            {
                throw new InvalidOperationException();
            }
            else
            {
                double x = Coordinates[0];
                double y = Coordinates[1];
                double z = Coordinates[2];

                List<double> coordinates = new List<double>
                {
                    x,
                    y * Math.Cos(angle) + z * Math.Sin(angle),
                    -y * Math.Sin(angle) + z * Math.Cos(angle)
                };
                return new Vector(coordinates);
            }
        }

        public Vector RotateByAngleOy(double angle)
        {
            if (Coordinates.Count != 3)
            {
                throw new InvalidOperationException();
            }
            else
            {
                double x = Coordinates[0];
                double y = Coordinates[1];
                double z = Coordinates[2];

                List<double> coordinates = new List<double>
                {
                    x * Math.Cos(angle) + z * Math.Sin(angle),
                    y,
                    -x * Math.Sin(angle) + z * Math.Cos(angle)
                };
                return new Vector(coordinates);
            }
        }

        public double GetAngle(int axisIndex)
        {
            return Coordinates[axisIndex] / Abs;
        }

        public static Vector operator*(double value, Vector vector)
        {
            List<double> coordinates = new List<double>();
            foreach(double coordinate in vector.Coordinates)
            {
                coordinates.Add(coordinate * value);
            }
            return new Vector(vector.Tag, coordinates);
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < vector1.Coordinates.Count && n < vector2.Coordinates.Count; ++n)
            {
                coordinates.Add(vector1.Coordinates[n] - vector2.Coordinates[n]);
            }
            return new Vector(coordinates);
        }

        public static double CharacterOfAngleBetweenVectors(Vector vector1, Vector vector2)
        {
            double result = 0;
            for(int n = 0; n < vector1.Coordinates.Count && n < vector2.Coordinates.Count; ++n)
            {
                result += vector1.Coordinates[n] * vector2.Coordinates[n];
            }
            return result;
        }

        public static double CosAngleBetweenVectors(Vector vector1, Vector vector2)
        {
            return CharacterOfAngleBetweenVectors(vector1, vector2) / (vector1.Abs + vector2.Abs);
        }
    }
}