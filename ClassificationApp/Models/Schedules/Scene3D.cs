using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Schedules
{
    public class Scene3D : IScene
    {
        Schedule3D _schedule3D = null;

        Camera3D _camera3D = new Camera3D();

        public ISchedule Schedule
        {
            get => _schedule3D;
            set
            {
                if(value is Schedule3D schedule3D)
                {
                    _schedule3D = schedule3D;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public List<IShape> Shapes { get; set; } = new List<IShape>();

        public ICamera Camera
        {
            get => _camera3D;
            set
            {
                if(value is Camera3D camera3D)
                {
                    _camera3D = camera3D;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Scene3D()
        {
        }

        public Scene3D(List<IShape> shapes, Camera3D camera3D, Schedule3D schedule3D)
        {
            Shapes = shapes;
            Camera = camera3D;
            Schedule = schedule3D;
        }
    }
}