using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APICODE.Function.Code;
using System.Reflection;

namespace RDC代码编辑器
{
    public class Program
    {
    
        [STAThread]
        private static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new Dll1.WindowAndFunction());
        }
    }
}
