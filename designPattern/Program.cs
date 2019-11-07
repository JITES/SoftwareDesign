using designPattern.creational.FactoryMethod;
using System;

namespace designPattern
{
    class Program
    {
        private static readonly string _test;
        static void xMain(string[] args)
        {
            
            int x = 10;
            int y = x++;
            int z = ++x;
            Console.WriteLine("{0} {1} {2}",x,y,z);
           
            Console.ReadKey();
        }
    }
}
