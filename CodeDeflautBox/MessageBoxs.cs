using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    class ShowMessageBox
    {
        public ShowMessageBox()
        {
            Display();
        }

        public void Display()
        {
            System.Windows.Forms.MessageBox.Show("Hello");
        }
    }
}
