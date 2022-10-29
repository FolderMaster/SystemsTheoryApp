using System;
using System.Drawing;

namespace ClassificationApp.Models.Schedules
{
    public class Camera3D : ICamera
    {
        private Scene3D _scene3D = null;

        private int _width = 0;

        private int _height = 0;

        public IScene Scene
        {
            get => _scene3D;
            set
            {
                if(value is Scene3D scene3D)
                {
                    _scene3D = scene3D;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Width
        {
            get => _width;
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }

        public Vector Vector { get; set; } = new Vector();

        public Image Shot
        {
            get
            {
                Bitmap bitmap = new Bitmap(Width, Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                foreach(IShape shape in Scene.Shapes)
                {

                }
                return bitmap;
            }
        }

        public Camera3D()
        {
        }

        public Camera3D(Scene3D scene3D)
        {
            Scene = scene3D;
        }

        public Camera3D(Scene3D scene3D, int width, int height, Vector vector)
        {
            Scene = scene3D;
            Width = width;
            Height = height;
            Vector = vector;
        }
    }
}