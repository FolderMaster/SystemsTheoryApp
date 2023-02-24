using System;
using System.Collections.Generic;
using System.Drawing;
using ClassificationApp.Models.Countries;
using ClassificationApp.Services.Factories;
using ClassificationApp.Services.Managers;

namespace ClassificationApp.Models.Scenes
{
    /// <summary>
    /// Класс трёхмерной камеры.
    /// </summary>
    public class Camera3D : ICamera
    {
        /// <summary>
        /// Трёхмерная сцена.
        /// </summary>
        private Scene3D _scene3D = null;

        /// <summary>
        /// Матрица представления-проекции.
        /// </summary>
        private double[,] _viewProjectionMatrix = new double[4, 4]
        {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        /// <summary>
        /// Матрица представления.
        /// </summary>
        private double[,] _viewMatrix = new double[4, 4]
        {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        /// <summary>
        /// Матрица проекции.
        /// </summary>
        private double[,] _projectionMatrix = new double[4, 4]
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { 0, 0, 0, 1}
        };

        /// <summary>
        /// Точка камеры.
        /// </summary>
        private Point _point = new Point(new List<double>() { 0, 0, 0 });

        /// <summary>
        /// Поворот камеры.
        /// </summary>
        private List<double> _rotation = new List<double>() { 0, 0, 0 };

        /// <summary>
        /// Длина проекционной плоскости.
        /// </summary>
        private int _width = 0;

        /// <summary>
        /// Длина высота плоскости.
        /// </summary>
        private int _height = 0;

        /// <summary>
        /// Глубина проекционной плоскости.
        /// </summary>
        private double _depth = 100;

        /// <summary>
        /// Режим отображения.
        /// </summary>
        private ProjectionMode _projectionMode = ProjectionMode.Perspective;

        /// <summary>
        /// Возращает и задает интерфейс сцены. Сцена должна быть трёхмерной.
        /// </summary>
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

        /// <summary>
        /// Возращает и задает режим отображения.
        /// </summary>
        public ProjectionMode ProjectionMode
        {
            get => _projectionMode;
            set => _projectionMode = value;
        }

        /// <summary>
        /// Возращает и задает вектор направления камеры.
        /// </summary>
        public Vector Vector { get; set; } = new Vector(new List<double>() { 1, 0, 0 });

        /// <summary>
        /// Возращает и задает точку камеры.
        /// </summary>
        public Point Point
        {
            get => _point;
            set
            {
                _point = value;
                UpdateViewMatrix();
            }
        }

        /// <summary>
        /// Возращает и задает поворот камеры.
        /// </summary>
        public List<double> Rotation
        {
            get => _rotation;
            set
            {
                _rotation = value;
                UpdateViewMatrix();
            }
        }

        /// <summary>
        /// Возращает и задает настройки камеры.
        /// </summary>
        public CameraDisplaySettings Settings { get; set; } = new CameraDisplaySettings();

        /// <summary>
        /// Возращает и задает длину проекционной плоскости.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                UpdateProjectionMatrix();
            }
        }

        /// <summary>
        /// Возращает и задает высоту проекционной плоскости.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                UpdateProjectionMatrix();
            }
        }

        /// <summary>
        /// Возращает и задает высоту проекционной плоскости.
        /// </summary>
        public double Depth
        {
            get => _depth;
            set
            {
                _depth = value;
                UpdateProjectionMatrix();
            }
        }

        /// <summary>
        /// Возращает и задает логическое значение, отображается ли тестовая информация в снимке.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Camera3D"/> по умолчанию.
        /// </summary>
        public Camera3D()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Camera3D"/>.
        /// </summary>
        /// <param name="scene3D">Трёхмерная сцена.</param>
        public Camera3D(Scene3D scene3D)
        {
            Scene = scene3D;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Camera3D"/>.
        /// </summary>
        /// <param name="scene3D">Трёхмерная сцена.</param>
        /// <param name="vector">Вектор направления камеры.</param>
        /// <param name="point">Точка камеры.</param>
        public Camera3D(Scene3D scene3D, Vector vector, Point point)
        {
            Scene = scene3D;
            Vector = vector;
            Point = point;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Camera3D"/>.
        /// </summary>
        /// <param name="scene3D">Трёхмерная сцена.</param>
        /// <param name="vector">Вектор направления камеры.</param>
        /// <param name="point">Точка камеры.</param>
        /// <param name="width">Длина проекционной плоскости.</param>
        /// <param name="height">Высота проекционной плоскости.</param>
        public Camera3D(Scene3D scene3D, Vector vector, Point point, int width, int height)
        {
            Scene = scene3D;
            Vector = vector;
            Point = point;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Обновляет матрицу представления.
        /// </summary>
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

        /// <summary>
        /// Обновляет матрицу проекции.
        /// </summary>
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

        /// <summary>
        /// Обновляет матрицу представления-проекции.
        /// </summary>
        private void UpdateViewProjectionMatrix()
        {
            _viewProjectionMatrix = MatrixManager.Multiply(_viewMatrix, _projectionMatrix);
        }

        /// <summary>
        /// Рисует строки на снимке.
        /// </summary>
        /// <param name="graphics">Объект графики.</param>
        /// <param name="font">Шрифт.</param>
        /// <param name="brush">Заливка для шрифта.</param>
        /// <param name="x">Координата OX.</param>
        /// <param name="y">Координата OY.</param>
        /// <param name="strings">Строки.</param>
        private void DrawStrings(Graphics graphics, Font font, Brush brush, int x, int y, string[]
            strings)
        {
            foreach (string value in strings)
            {
                graphics.DrawString(value, font, brush, x, y);
                y += (int)graphics.MeasureString(value, font).Height;
            }
        }

        /// <summary>
        /// Рисует легенду на снимке.
        /// </summary>
        /// <param name="graphics">Объект графики.</param>
        /// <param name="font">Шрифт.</param>
        /// <param name="pen">Ручка для квадратов.</param>
        /// <param name="fontBrush">Заливка для шрифта.</param>
        /// <param name="x">Координата OX.</param>
        /// <param name="y">Координата OY.</param>
        /// <param name="width">Длина квадратов.</param>
        /// <param name="colorBrushes">Цветные заливки квадратов.</param>
        /// <param name="strings">Строки.</param>
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

        /// <summary>
        /// Отображает точку.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <returns>Отображение точки.</returns>
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

        /// <summary>
        /// Отображает отрезок.
        /// </summary>
        /// <param name="lineSegment">Отрезок.</param>
        /// <returns>Отображение отрезка.</returns>
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

        /// <summary>
        /// Отображает плоскость.
        /// </summary>
        /// <param name="plane">Плоскость.</param>
        /// <returns>Полигон отображения плоскости.</returns>
        public Polygon GetDisplay(Plane plane)
        {
            return new Polygon(plane.Tag);
        }

        /// <summary>
        /// Поворачивает камеру по оси OX.
        /// </summary>
        /// <param name="angle">Угол поворота.</param>
        public void RotateOX(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0] + angle,
                Rotation[1],
                Rotation[2]
            };
        }

        /// <summary>
        /// Поворачивает камеру по оси OY.
        /// </summary>
        /// <param name="angle">Угол поворота.</param>
        public void RotateOY(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0],
                Rotation[1] + angle,
                Rotation[2]
            };
        }

        /// <summary>
        /// Поворачивает камеру по оси OZ.
        /// </summary>
        /// <param name="angle">Угол поворота.</param>
        public void RotateOZ(double angle)
        {
            Rotation = new List<double>()
            {
                Rotation[0],
                Rotation[1],
                Rotation[2] + angle
            };
        }

        /// <summary>
        /// Передвигает камеры по направлению камеры.
        /// </summary>
        /// <param name="stepsAmount">Количество шагов.</param>
        public void Go(double stepsAmount)
        {
            Point = Point.MoveByVector(stepsAmount * ShapeFactory.CreateOrtByAngles(Rotation));
        }
    }
}