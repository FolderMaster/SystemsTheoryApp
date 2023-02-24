using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Views.Controls
{
    /// <summary>
    /// Элемент управления для просмотра трёхмерной сцены.
    /// </summary>
    public partial class Scene3DDisplayControl : UserControl
    {
        /// <summary>
        /// Количество шагов для движения по умолчанию.
        /// </summary>
        private const double _defaultStepsAmount = 1;

        /// <summary>
        /// Угол для поворота по умолчанию.
        /// </summary>
        private const double _defaultAngle = Math.PI / 180;

        /// <summary>
        /// Трёхмерная сцена.
        /// </summary>
        private Scene3D _scene3D;

        /// <summary>
        /// Возращает трёхмерную камеру.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Camera3D Camera3D
        {
            get => (Camera3D)Scene3D.Camera;
        }

        /// <summary>
        /// Возращает и задаёт трёхмерную камеру.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Scene3D Scene3D
        {
            get => _scene3D;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _scene3D = value;
                    Camera3D.Width = Width;
                    Camera3D.Height = Height;

                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Scene3DDisplayControl"/> по умолчанию.
        /// </summary>
        public Scene3DDisplayControl()
        {
            InitializeComponent();

            Scene3D = new Scene3D();
        }


        /// <summary>
        /// Вращает камеру по оси OX.
        /// </summary>
        private void RotateOX()
        {
            Camera3D.RotateOX(_defaultAngle);
        }

        /// <summary>
        /// Вращает в обратную сторону камеру по оси OX.
        /// </summary>
        private void ReverseRotateOX()
        {
            Camera3D.RotateOX(-_defaultAngle);
        }

        /// <summary>
        /// Вращает камеру по оси OY.
        /// </summary>
        private void RotateOY()
        {
            Camera3D.RotateOY(_defaultAngle);
        }

        /// <summary>
        /// Вращает в обратную сторону камеру по оси OY.
        /// </summary>
        private void ReverseRotateOY()
        {
            Camera3D.RotateOY(-_defaultAngle);
        }

        /// <summary>
        /// Вращает камеру по оси OZ.
        /// </summary>
        private void RotateOZ()
        {
            Camera3D.RotateOZ(_defaultAngle);
        }

        /// <summary>
        /// Вращает в обратную сторону камеру по оси OZ.
        /// </summary>
        private void ReverseRotateOZ()
        {
            Camera3D.RotateOZ(-_defaultAngle);
        }

        /// <summary>
        /// Двигает камеру по направлению.
        /// </summary>
        private void GoAhead()
        {
            Camera3D.Go(_defaultStepsAmount);
        }

        /// <summary>
        /// Двигает камеру в обратном напрвлении.
        /// </summary>
        private void GoBack()
        {
            Camera3D.Go(-_defaultStepsAmount);
        }

        private void Schedule3DControl_Resize(object sender, EventArgs e)
        {
            Camera3D.Width = Width;
            Camera3D.Height = Height;

            Invalidate();
        }

        private void Scene3DDisplayControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q': case 'Q': ReverseRotateOX(); break;
                case 'w': case 'W': GoAhead(); break;
                case 'e': case 'E': RotateOX(); break;
                case 'a': case 'A': ReverseRotateOY(); break;
                case 's': case 'S': GoBack(); break;
                case 'd': case 'D': RotateOY(); break;
                case 'z': case 'Z': ReverseRotateOZ(); break;
                case 'x': case 'X': RotateOZ(); break;
            }

            Invalidate();
        }

        private void Schedule3DControl_Paint(object sender, PaintEventArgs e)
        {
            if (Camera3D.Width != 0 && Camera3D.Height != 0)
            {
                e.Graphics.DrawImage(Scene3D.Camera.Shot, 0, 0, Width, Height);
            }
        }
    }
}