using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    public class Scene3D : IScene
    {
        Graph3D _graph3D = new Graph3D();

        Camera3D _camera3D = null;

        public IGraph Graph
        {
            get => _graph3D;
            set
            {
                if(value is Graph3D schedule3D)
                {
                    _graph3D = schedule3D;
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
            Camera = new Camera3D(this);
        }

        public Scene3D(List<IShape> shapes, Camera3D camera3D, Graph3D schedule3D)
        {
            Shapes = shapes;
            Camera = camera3D;
            Graph = schedule3D;
        }
    }
}