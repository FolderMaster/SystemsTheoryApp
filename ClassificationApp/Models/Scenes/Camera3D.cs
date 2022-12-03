using System;
using System.Collections.Generic;
using System.Drawing;

using ClassificationApp.Models.Countries;

namespace ClassificationApp.Models.Scenes
{
    public class Camera3D : ICamera
    {
        private Scene3D _scene3D = null;

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
        
        public Vector Vector { get; set; } = new Vector(new List<double>() { 1, 0, 0 });

        public Point Point { get; set; } = new Point(new List<double>() { 0, 0, 0 });

        public Camera3DSettings Settings { get; set; } = new Camera3DSettings();

        public double Distance { get; set; } = 0;

        public int Width { get; set; } = 0;

        double WidthAngle { get; set; } = 0;

        public int Height { get; set; } = 0;

        double HeightAngle { get; set; } = 0;

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

        public Camera3D(Scene3D scene3D, Vector vector, Point point, int width, int height, double
            widthAngle, double heightAngle)
        {
            Scene = scene3D;
            Vector = vector;
            Point = point;
            Width = width;
            Height = height;
            WidthAngle = widthAngle;
            HeightAngle = heightAngle;
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
            double xAngle = Vector.GetAngle(0);
            double yAngle = Vector.GetAngle(1);
            double zAngle = Vector.GetAngle(2);

            double cx = Math.Cos(xAngle);
            double cy = Math.Cos(yAngle);
            double cz = Math.Cos(zAngle);

            double sx = Math.Sin(xAngle);
            double sy = Math.Sin(yAngle);
            double sz = Math.Sin(zAngle);

            double x = point.Coordinates[0] - Point.Coordinates[0];
            double y = point.Coordinates[1] - Point.Coordinates[1];
            double z = point.Coordinates[2] - Point.Coordinates[2];

            double ex = Vector.Coordinates[0];
            double ey = Vector.Coordinates[1];
            double ez = Vector.Coordinates[2];

            double dx = cy * (sz * y + cz * x) - sy * z;
            double dy = sx * (cy * z + sy * (sz * y + cz * x)) + cx * (cz * y - sz * x);
            double dz = cx * (cy * z + sy * (sz * y + cz * x)) - sx * (cz * y - sz * x);

            double bx = ez / dz * dx + ex;
            double by = ez / dz * dy + ey;

            bx += Width / 2;
            by += Height / 2;

            if ((bx >= 0 && bx < Width) && (by >= 0 && by < Height))
            {
                return new Point(point.Tag, new List<double>() { bx, by });
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