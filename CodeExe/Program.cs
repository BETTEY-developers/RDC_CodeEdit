using System;

namespace CodeExe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadKey();
        }
    }
}
