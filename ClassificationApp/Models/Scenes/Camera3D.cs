using System;
using System.Collections.Generic;
using System.Drawing;
using ClassificationApp.Models.Countries;
using ClassificationApp.Services.Factories;
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

        private int _width = 0;

        private int _height = 0;

        private double _depth = 100;

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
            set => _projectionMode = value;
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

        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                UpdateProjectionMatrix();
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                UpdateProjectionMatrix();
            }
        }

        public double Depth
        {
            get => _depth;
            set
            {
                _depth = value;
                UpdateProjectionMatrix();
            }
        }

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
                            int x = (int)point.Coordinates[0] + Width / 2;
                            int y = (int)point.Coordinates[1] + Height / 2;
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
                    else if(shape is LineSegment lineSegment)
                    {
                        lineSegment = GetDisplay(lineSegment);
                        if(lineSegment != null)
                        {
                            int x1 = (int)lineSegment.Begin[0] + Width / 2;
                            int y1 = (int)lineSegment.Begin[1] + Height / 2;
                            int x2 = (int)lineSegment.End[0] + Width / 2;
                            int y2 = (int)lineSegment.End[1] + Height / 2;

                            graphics.DrawLine(Settings.PointPen, x1, y1, x2, y2);
                        }
                    }
                }
                if(IsTest)
                {
                    DrawStrings(graphics, Settings.Font, Settings.FontBrush, 0, 0, new string[]
                    {
                        "Camera",
                        "Point",
                        "x:" + Point[0].ToString(),
                        "y:" + Point[1].ToString(),
                        "z:" + Point[2].ToString(),
                        "Rotation",
                        "x:" + Rotation[0].ToString(),
                        "y:" + Rotation[1].ToString(),
                        "z:" + Rotation[2].ToString(),
                        "Projection:" + ProjectionMode.ToString(),
                        "Width:" + Width.ToString(),
                        "Height:" + Height.ToString(),
                        "Depth:" + Depth.ToString()
                    });
                }
                DrawLegend(graphics, Settings.Font, Settings.LegendPen, Settings.FontBrush, 0, 300,
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
            _projectionMatrix = new double[4, 4]
            {
                { Width / 2, 0, 0, 0 },
                { 0, Height / 2, 0, 0 },
                { 0, 0, Depth / 2, 0 },
                { -1, 1, 0, 1 }
            };
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
            double[,] coordinates = MatrixManager.Multiply(_viewProjectionMatrix,
                new double[4, 1]
                {
                    { point[0] },
                    { point[1] },
                    { point[2] },
                    { 1 }
                });
            if(ProjectionMode == ProjectionMode.Perspective)
            {
                double zToDivideBy = 1 + coordinates[2, 0];
                coordinates[0, 0] /= zToDivideBy;
                coordinates[1, 0] /= zToDivideBy;
            }
            return new Point(point.Tag, new List<double>() { coordinates[0, 0], coordinates[1, 0] });
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

        public void RotateOX(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0] + angle,
                Rotation[1],
                Rotation[2]
            };
        }

        public void RotateOY(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0],
                Rotation[1] + angle,
                Rotation[2]
            };
        }

        public void RotateOZ(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0],
                Rotation[1],
                Rotation[2] + angle
            };
        }

        public void Go(double stepsAmount)
        {
            Point = Point.MoveByVector(stepsAmount * ShapeFactory.CreateOrtByAngles(Rotation));
        }
    }
}