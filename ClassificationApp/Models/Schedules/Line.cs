using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassificationApp.Models.Schedules
{
    public class Line : IShape
    {
        public double Argument { get; set; } = 0;

        public List<double> Arguments { get; set; } = new List<double>();

        public Line()
        {
        }

        public Line(double argument, IEnumerable<double> arguments)
        {
            Argument = argument;
            Arguments = arguments.ToList();
        }

        public IShape Display(ISchedule schedule)
        {
            throw new NotImplementedException();
        }

        public double GetMax(ISchedule schedule, int axisIndex)
        {
            if(axisIndex >= Arguments.Count)
            {
                throw new ArgumentException();
            }
            else
            {

            }
        }

        public double GetMin(ISchedule schedule, int axisIndex)
        {
            if (axisIndex >= Arguments.Count)
            {
                throw new ArgumentException();
            }
            else
            {

            }
        }
    }
}