using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dll1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void a()
        {
            Process pro = new Process();
            WindowAndFunction waf = new WindowAndFunction();

            pro.StartInfo.FileName = waf.openFileDialog1.FileName + ".exe";
            pro.StartInfo.UseShellExecute = false;
            pro.StartInfo.RedirectStandardError = true;
            pro.StartInfo.RedirectStandardInput = true;
            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.CreateNoWindow = true;

            pro.Start();
            string line;
            while ((line = pro.StandardOutput.ReadToEnd()) != "\n")
                textBox1.AppendText(line);
            pro.Close();

        }

    }
}
