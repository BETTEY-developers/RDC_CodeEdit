using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
    public class Program
    {
        public static void Write(params string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            Write(args);
        }
    }
}
