using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll1;

namespace 插件接口测试
{
    class Program : Dll1.IRDCEAPIPLUGININTERFACE
    {
        public void IRDCEAPIPLUGININTERFACE.ACode()
        {
            Console.WriteLine("im acode");
        }
        static void Main(string[] args)
        {
            IRDCEAPIPLUGININTERFACE a;
            WindowAndFunction waf = new WindowAndFunction();
            a = new IRDCEAPIPLUGININTERFACE();
            waf.Plugmain(a);
        }
    }
}
