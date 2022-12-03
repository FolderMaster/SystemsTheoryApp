using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ClassificationApp.Models.Scenes;

namespace ClassificationApp.Views.Controls
{
    public partial class Scene3DDisplayControl : UserControl
    {
        private const double _defaultStepsAmount = 1;

        private const double _defaultAngle = Math.PI / 180;

        private Scene3D _scene3D;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Camera3D Camera3D
        {
            get => (Camera3D)Scene3D.Camera;
        }

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

        public Scene3DDisplayControl()
        {
            InitializeComponent();

            Scene3D = new Scene3D();
        }

        private void RotateRight()
        {
            Camera3D.RotateHorizontally(_defaultAngle);
        }

        private void RotateLeft()
        {
            Camera3D.RotateHorizontally(-_defaultAngle);
        }

        private void RotateUp()
        {
            Camera3D.RotateVertically(_defaultAngle);
        }

        private void RotateDown()
        {
            Camera3D.RotateVertically(-_defaultAngle);
        }

        private void GoAhead()
        {
            Camera3D.Go(_defaultStepsAmount);
        }

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
                case 'w': case 'W': GoAhead(); break;
                case 's': case 'S': GoBack(); break;
                case 'a': case 'A': RotateLeft(); break;
                case 'd': case 'D': RotateRight(); break;
                case 'q': case 'Q': RotateDown(); break;
                case 'e': case 'E': RotateUp(); break;
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