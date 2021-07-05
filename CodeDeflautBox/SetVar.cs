using Dll1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    class SetVar
    {
        public string join(string separator, params string[] s)
        {
            if(s.Length > 0)
            {
                for(int i = 0; i < s.Length - 1; i++)
                {
                    s[0] = s[0] + " " + s[i];
                }
                return s[0];
            }
            else
            {
                return s[0];
            }
        }
        public SetVar(int mode)
        {
            if(mode == (int)'S')
            {
                S();
            }
            else if (mode == (int)'M')
            {
                M();
            }
            else if(mode == (int)'W')
            {
                
            }
        }

        private void M()
        {
            int a = 0, b = 0;
            System.Windows.MessageBox.Show(join(" ", nameof(a), "=", a.ToString(), "\n", nameof(b), "=", b.ToString(), "\n"));
            a = 10; 
            b = 20;
            System.Windows.Forms.MessageBox.Show(join("", nameof(a), "=", a.ToString(), "\n", nameof(b), "=", b.ToString(), "\n"));//nameof(a), "+", nameof(b), "=", (a + b).ToString()
            System.Windows.Forms.MessageBox.Show(join("", nameof(a), "+", nameof(b), "=", (a + b).ToString()));
        }

        private int S()
        {
            int a = 0, b = 0;
            Console.WriteLine("", nameof(a), "=", a.ToString(), "\n", nameof(b), "=", b.ToString(), "\n");
            a = 10;
            b = 20;
            Console.WriteLine(join("", nameof(a), "=", a.ToString(), "\n", nameof(b), "=", b.ToString(), "\n"));
            Console.WriteLine(join("", nameof(a), "+", nameof(b), "=", (a + b).ToString()));
            Console.ReadKey();
            return 0;
        }
    }
}
