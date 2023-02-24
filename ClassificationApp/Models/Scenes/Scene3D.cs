using System;
using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс трёхмерной сцены с трёхмерными графиком, камерой и фигурами.
    /// </summary>
    public class Scene3D : IScene
    {
        /// <summary>
        /// Трёхмерный график.
        /// </summary>
        Graph3D _graph3D = new Graph3D();

        /// <summary>
        /// Трёхмерная камера.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Scene3D"/> по умолчанию.
        /// </summary>
        public Scene3D()
        {
            Camera = new Camera3D(this);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Scene3D"/>.
        /// </summary>
        /// <param name="shapes">Фигуры.</param>
        /// <param name="camera3D">Трёхмерная камера.</param>
        /// <param name="schedule3D">Трёхмерный график.</param>
        public Scene3D(List<IShape> shapes, Camera3D camera3D, Graph3D schedule3D)
        {
            Shapes = shapes;
            Camera = camera3D;
            Graph = schedule3D;
        }
    }
}