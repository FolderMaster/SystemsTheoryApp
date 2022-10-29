
using System.Collections.Generic;

namespace ClassificationApp.Models.Schedules
{
    public class Vector : IShape
    {
        public object Tag { get; set; } = null;

        public List<double> Coordinates { get; set; } = new List<double>();

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

        public IShape Display(ISchedule schedule)
        {
            return new Vector(Tag, Coordinates);
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            throw new System.NotImplementedException();
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            throw new System.NotImplementedException();
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
    }
}
