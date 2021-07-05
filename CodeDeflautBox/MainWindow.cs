using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CodeDeflautBox
{
    public partial class MainWindow : Form
    {
        Dll1.WindowAndFunction waf;
        public MainWindow(Dll1.WindowAndFunction Waf)
        {
            waf = Waf;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RunProgram('M', 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new WriteCode("Hello", waf);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RunProgram('S', 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new WriteCode("Message", waf);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ShowMessageBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new RunProgram('M', 3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new WriteCode("OperatorVar", waf);
        }
    }
    public class Code
    {
        public string this[string name]
        {
            get
            {
                if(name == "HelloWorld")
                {
                    return Properties.WriteCode.HelloWorld;
                }
                else if (name == "MessageBox")
                {
                    return Properties.WriteCode.MessageBox;
                }
                else if (name == "SetVar")
                {
                    return Properties.WriteCode.SetVar;
                }
                else if(name == "Operator")
                {
                    return Properties.WriteCode.OperatorVar;
                }
                else
                {
                    return "\u0000";
                }
            }
        }
    }
    
}
