using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    class HelloWorld
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        extern static Boolean AllocConsole();
        public HelloWorld(int mode)
        {
            if(mode == (int)'S')
            {
                S();
            }
            else if(mode == (int)'M')
            {
                M();
            }
        }

        private void S()
        {
            Funcs.Cl(new string[1]{"HelloWorld!"});
        }

        private void M()
        {
            System.Windows.Forms.MessageBox.Show("Hello World");
        }
    }
}
