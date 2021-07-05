using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    class OperatorVar
    {
        public OperatorVar(int mode)
        {
            if (mode == (int)'S')
            {
                S();
            }
            else if (mode == (int)'M')
            {
                M();
            }
        }

        private void M()
        {
            int a = 50;
            int b = 10;
            string text = $"{nameof(a)} = {a}\n{nameof(b)} = {b}\n {nameof(a)} * {nameof(b)} = {a * b}";
            System.Windows.Forms.MessageBox.Show(text);
        }

        private int S()
        {
            int a = 50;
            Console.WriteLine($"{nameof(a)} = {a}");
            int b = 10;
            Console.WriteLine($"{nameof(b)} = {b}");
            Console.WriteLine($"{nameof(a)} * {nameof(b)} = {a * b}");
            Funcs.Cl(new string[] { $"{nameof(a)} = {a}", $"{nameof(b)} = {b}", $"{nameof(a)} * {nameof(b)} = {a * b}" });
            return 0;
        }
    }
}
