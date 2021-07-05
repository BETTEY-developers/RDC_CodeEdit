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
    public partial class QSave : Form
    {
        string fns;
        TextBox Code = new TextBox();
        public QSave(string fn, string code)
        {
            InitializeComponent();
            label1.Text = label1.Text + fn;
            fns = fn;
            Code.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowAndFunction waf = new WindowAndFunction();
            waf.SaveFile(fns, Code.Text);
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
