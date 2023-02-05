using System;

namespace toplama
{
    class Program
    {
        public static int b;
        static void Main(string[] args)
        {
            int a = 10;
            {
                b = 20;
            }
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
