using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dll1
{
    public class Startone
    {
        static WindowAndFunction waf;
        public Form Load1()
        {
            waf = new WindowAndFunction();
            waf.Show();
            return waf;
        }
        
    }
}
