using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassificationApp.Models.Schedules;

namespace ClassificationApp.Views.Controls
{
    public partial class Schedule3DControl : UserControl
    {
        Schedule3D _schedule = new Schedule3D();

        Schedule3D Schedule3D
        {
            get => _schedule;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _schedule = value;
                    _schedule.DefaultDisplay();

                    Invalidate();
                }
            }
        }

        public Schedule3DControl()
        {
            InitializeComponent();
        }

        private void Schedule3DControl_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Schedule3DControl_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
