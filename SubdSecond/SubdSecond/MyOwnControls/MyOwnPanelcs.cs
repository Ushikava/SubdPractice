using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubdSecond.MyOwnControls
{
    public partial class MyOwnPanelcs : UserControl
    {
        public MyOwnPanelcs()
        {
            InitializeComponent();
        }

        private void MyOwnPanelcs_SizeChanged(object sender, EventArgs e)
        {
            PaintForm();
        }

        public void PaintForm()
        {
            int x = 0;
            int y = 0;
            int offset = 15;

            foreach (Control i in Controls)
            {
                if ((x + i.Width) > this.Width)
                {
                    x = 0;
                    y = (y + i.Height + offset);
                    i.Location = new Point(x + offset, y + offset);
                    x = (x + i.Width + offset);
                }
                else
                {
                    i.Location = new Point(x + offset, y + offset);
                    x = (x + i.Width + offset);
                }
            }
        }
    }
}
