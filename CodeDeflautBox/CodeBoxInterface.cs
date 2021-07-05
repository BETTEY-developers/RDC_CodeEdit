using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDeflautBox
{
    interface IProgram
    {
        void M();//MessageBox
        int S();//Console
    }
    interface IMessageBox
    {
        void Display();
    }
    interface IAddCodeBox
    { 
        
    }
}
