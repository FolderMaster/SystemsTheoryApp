using System;
using System.Collections.Generic;
using System.Drawing;

using ClassificationApp.Services.Factories;

namespace ClassificationApp.Models.Scenes
{
    public class Camera3D : ICamera
    {
        private Scene3D _scene3D = null;

        private Vector VectorOx { get; set; } = null;

        private Vector VectorOy { get; set; } = null;

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
        
        public Vector Vector { get; set; } = new Vector(new List<double>() { 0.5, 0.5, 0 });

        public Point Point { get; set; } = new Point(new List<double>() { 0, 0, 0 });

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
                VectorOx = Width * Vector.RotateByAngleOx(Math.PI / 2).Ort;
                VectorOy = Height * Vector.RotateByAngleOy(Math.PI / 2).Ort;
                Bitmap bitmap = new Bitmap(Width, Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                Font font = new Font(FontFamily.GenericMonospace, 12);
                Brush fontBrush = new SolidBrush(Color.Black);
                Brush pointBrush = new SolidBrush(Color.Black);
                Pen pointPen = new Pen(Color.Red);
                int pointSize = 10;
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

                            graphics.DrawEllipse(pointPen, x - pointSize / 2, Height - y
                                - pointSize / 2, pointSize, pointSize);
                            graphics.FillEllipse(pointBrush, x - pointSize / 2, Height - y -
                                pointSize / 2, pointSize, pointSize);
                        }
                    }
                }
                if(IsTest)
                {
                    DrawStrings(graphics, font, fontBrush, 0, 0, new string[] { "Camera",
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
                DrawLegend(graphics, font, fontBrush, 0, 240, 20, new Brush[] { pointBrush,
                    pointPen.Brush }, new string[] { " - brush of point", " - pen of point" });
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

        private void DrawLegend(Graphics graphics, Font font, Brush fontBrush, int x, int y, int
            width, Brush[] colorBrushes, string[] strings)
        {
            Pen pen = new Pen(Color.Black);
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
            List<double> coordinates = new List<double>
            {
                point.Coordinates[0] * (Point.Coordinates[2] + Distance) / point.Coordinates[2],
                point.Coordinates[1] * (Point.Coordinates[2] + Distance) / point.Coordinates[2]
            };
            return new Point(coordinates);
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