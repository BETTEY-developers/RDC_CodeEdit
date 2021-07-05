using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPS
{
    public partial class Form1 : Form
    {
        bool ismouse = true;
        int WM_CREATEWINDOW = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismouse = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismouse = true;
            if ((this.Location.X - e.X) <= 710 && (this.Location.Y - e.Y) <= 32)
            {
                while (ismouse)
                {
                    Location = new Point(e.X, e.Y);
                }
            }
        }
    }
}
