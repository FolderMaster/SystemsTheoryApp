using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassificationApp.Models.Countries;
using ClassificationApp.Services.Managers;

namespace ClassificationApp.Models.Scenes
{
    public class Camera3D : ICamera
    {
        private Scene3D _scene3D = null;

        private double[,] _viewProjectionMatrix = new double[4, 4]
        {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        private double[,] _viewMatrix = new double[4, 4]
        {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        private double[,] _projectionMatrix = new double[4, 4]
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { 0, 0, 0, 1}
        };

        private Point _point = new Point(new List<double>() { 0, 0, 0 });

        private List<double> _rotation = new List<double>() { 0, 0, 0 };

        private ProjectionMode _projectionMode = ProjectionMode.Perspective;

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

        public ProjectionMode ProjectionMode
        {
            get => _projectionMode;
            set
            {
                _projectionMode = value;
                UpdateProjectionMatrix();
            }
        }
        
        public Vector Vector { get; set; } = new Vector(new List<double>() { 1, 0, 0 });

        public Point Point
        {
            get => _point;
            set
            {
                _point = value;
                UpdateViewMatrix();
            }
        }

        public List<double> Rotation
        {
            get => _rotation;
            set
            {
                _rotation = value;
                UpdateViewMatrix();
            }
        }

        public CameraDisplaySettings Settings { get; set; } = new CameraDisplaySettings();

        public int Width { get; set; } = 0;

        public int Height { get; set; } = 0;

        public bool IsTest { get; set; } = true;

        public Image Shot
        {
            get
            {
                Bitmap bitmap = new Bitmap(Width, Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(new Pen(Color.Red), 0, 0, Width - 1, Height - 1);
                foreach (IShape shape in Scene.Shapes)
                {
                    
                }
                foreach (IShape shape in Scene.Graph.Displays)
                {
                    if(shape is Point point)
                    {
                        point = GetDisplay(point);
                        if(point != null)
                        {
                            int x = (int)point.Coordinates[0];
                            int y = (int)point.Coordinates[1];
                            Brush pointBrush;
                            switch(point.Tag)
                            {
                                case CountryType.None: pointBrush = Settings.NoneBrush; break;
                                case CountryType.Developing: pointBrush = Settings.DevelopingBrush; break;
                                case CountryType.Developed: pointBrush = Settings.DevelopedBrush; break;
                                default: pointBrush = Settings.DefaultBrush; break;
                            }

                            graphics.DrawEllipse(Settings.PointPen, x - Settings.PointSize / 2, Height - y
                                - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                            graphics.FillEllipse(pointBrush, x - Settings.PointSize / 2, Height - y -
                                Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                        }
                    }
                }
                if(IsTest)
                {
                    DrawStrings(graphics, Settings.Font, Settings.FontBrush, 0, 0, new string[] { "Camera",
                        "Width:" + Width,
                        "Heighth:" + Height,
                        "Vector",
                        "x:" + Vector.Coordinates[0].ToString(),
                        "y:" + Vector.Coordinates[1].ToString(),
                        "z:" + Vector.Coordinates[2].ToString(),
                        "Point",
                        "x:" + Point.Coordinates[0].ToString(),
                        "y:" + Point.Coordinates[1].ToString(),
                        "z:" + Point.Coordinates[2].ToString()});
                }
                DrawLegend(graphics, Settings.Font, Settings.LegendPen, Settings.FontBrush, 0, 240,
                    20, new Brush[] { Settings.NoneBrush,  Settings.DevelopedBrush, 
                        Settings.DevelopingBrush, Settings.DefaultBrush }, new string[] 
                        { " - none", " - developed", " - developing", " - default"});
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

        public Camera3D(Scene3D scene3D, Vector vector, Point point)
        {
            Scene = scene3D;
            Vector = vector;
            Point = point;
        }

        public Camera3D(Scene3D scene3D, Vector vector, Point point, int width, int height)
        {
            Scene = scene3D;
            Vector = vector;
            Point = point;
            Width = width;
            Height = height;
        }

        private void UpdateViewMatrix()
        {
            double[,] xRotationMatrix = new double[4, 4]
            {
                { 1, 0, 0, 0},
                { 0, Math.Cos(-Rotation[0]), -Math.Sin(-Rotation[0]), 0},
                { 0, Math.Sin(-Rotation[0]), Math.Cos(-Rotation[0]), 0},
                { 0, 0, 0, 1}
            };

            double[,] yRotationMatrix = new double[4, 4]
            {
                { Math.Cos(-Rotation[1]), 0, Math.Sin(-Rotation[1]), 0},
                { 0, 1, 0, 0},
                { -Math.Sin(-Rotation[1]), 0, Math.Cos(-Rotation[1]), 0},
                { 0, 0, 0, 1}
            };

            double[,] zRotationMatrix = new double[4, 4]
            {
                { Math.Cos(-Rotation[2]), Math.Sin(-Rotation[2]), 0, 0},
                { -Math.Sin(-Rotation[2]), Math.Cos(-Rotation[2]), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };

            double[,] positionMatrix = new double[4, 4]
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { -Point[0], -Point[1], -Point[2], 1}
            };

            _viewMatrix = MatrixManager.Multiply(zRotationMatrix, 
                MatrixManager.Multiply(yRotationMatrix, 
                MatrixManager.Multiply(xRotationMatrix, positionMatrix)));
            UpdateViewProjectionMatrix();
        }

        private void UpdateProjectionMatrix()
        {
            double r;
            double t;
            double f;
            double n;
            switch(ProjectionMode)
            {
                case ProjectionMode.Ortographic:
                    r = 2;
                    t = 2;
                    f = 100;
                    n = 0.1;
                    _projectionMatrix = new double[4, 4]
                    {
                        { 1 / r, 0, 0, 0 },
                        { 0, 1 / t, 0, 0 },
                        { 0, 0, -2 / (f - n), 0 },
                        { 0, 0, (-f - n) / (f - n), 1 }
                    };
                    break;
                case ProjectionMode.Perspective:
                    r = 0.1;
                    t = 0.1;
                    f = 10;
                    n = 0.1;
                    _projectionMatrix = new double[4, 4]
                    {
                        { n / r, 0, 0, 0 },
                        { 0, n / t, 0, 0 },
                        { 0, 0, (-f - n) / (f - n), -1 },
                        { 0, 0, -2 * f * n / (f - n), 0 }
                    };
                    break;
                default: throw new ArgumentException();
            }
            UpdateViewProjectionMatrix();
        }

        private void UpdateViewProjectionMatrix()
        {
            _viewProjectionMatrix = MatrixManager.Multiply(_viewMatrix, _projectionMatrix);
        }

        private void DrawStrings(Graphics graphics, Font font, Brush brush, int x, int y, string[]
            strings)
        {
            foreach (string value in strings)
            {
                graphics.DrawString(value, font, brush, x, y);
                y += (int)graphics.MeasureString(value, font).Height;
            }
        }

        private void DrawLegend(Graphics graphics, Font font, Pen pen, Brush fontBrush, int x, int y, int
            width, Brush[] colorBrushes, string[] strings)
        {
            for(int n = 0; n < colorBrushes.Length && n < strings.Length; n++)
            {
                graphics.DrawRectangle(pen, x, y, width, graphics.MeasureString(strings[n], font).Height);
                graphics.FillRectangle(colorBrushes[n], x, y, width, graphics.MeasureString(strings[n], font).Height);
                graphics.DrawString(strings[n], font, fontBrush, x + width, y);
                y += (int)graphics.MeasureString(strings[n], font).Height;
            }
        }

        public Point GetDisplay(Point point)
        {
            double[,] coordinates = MatrixManager.Multiply(new double[4, 1]
            {
                { point[0] },
                { point[1] },
                { point[2] },
                { 1 }
            }, _viewProjectionMatrix);
            if (true)
            {
                return new Point(point.Tag, new List<double>() { coordinates[0, 0], coordinates[1, 0] });
            }
            else
            {
                return null;
            }
        }

        public LineSegment GetDisplay(LineSegment lineSegment)
        {
            Point begin = GetDisplay(lineSegment.Begin);
            Point end = GetDisplay(lineSegment.End);
            if(begin != null && end != null)
            {
                return new LineSegment(lineSegment.Tag, begin, end);
            }
            else
            {
                return null;
            }
        }

        public Polygon GetDisplay(Plane plane)
        {
            return new Polygon(plane.Tag);
        }

        public void RotateHorizontally(double angle)
        {
            Vector = Vector.RotateByAngleOx(angle);
        }

        public void RotateVertically(double angle)
        {
            Vector = Vector.RotateByAngleOy(angle);
        }

        public void Go(double stepsAmount)
        {
            Point = Point.MoveByVector(stepsAmount * Vector.Ort);
        }
    }
}