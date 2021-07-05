using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dll1
{
    public partial class sgWH : Form
    {
        int x, y, w, h, X, Y;
        WindowAndFunction waf;
        public sgWH(WindowAndFunction window)
        {
            InitializeComponent();
            waf = window;
            x = waf.Location.X;
            y = waf.Location.Y;
            Rectangle wh = new Rectangle();
            w = wh.Width;
            h = wh.Height;
            WHWT.Text = "父窗口所在的坐标 X:" + x + " Y: " + y + "\n屏幕宽：" + w + " 屏幕高：" + h;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                X = Convert.ToInt16(XL.Text);
                Y = Convert.ToInt16(YL.Text);
            }
            catch (FormatException)
            {
                Console.Beep();
                MessageBox.Show("输入有误，请重新输入！");
                return;
            }
            catch (OverflowException)
            {
                Console.Beep();
                MessageBox.Show("溢出内存，请重新输入！");
                return;
            }
            Point xy = new Point(X, Y);
            waf.Location = xy;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
