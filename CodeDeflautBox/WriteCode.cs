using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    class WriteCode
    {
        public WriteCode(string name, Dll1.WindowAndFunction waf)
        {
            Code code = new Code();
            waf.Code.Text = code[name];
        }
    }
}
