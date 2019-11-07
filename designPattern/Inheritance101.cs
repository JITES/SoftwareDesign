using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace designPattern
{
   class A
    {
        protected int i = 100;
        public A()
        {
            Console.WriteLine("A is called");
        }
        public virtual void F()
        {
            Console.WriteLine("A.F");
        }
        public void H()
        {
            Console.WriteLine("This is A.H");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine(value: i);
            i = 0;
            Console.WriteLine(value: i);
            Console.WriteLine("B is called");
        }
        public override  void F()
        {
            Console.WriteLine("B.F");
        }
        public void G()
        {
            Console.WriteLine("This is B.G");
        }
    }

    class Test
    {
        static void DMain()
        {
            B b = new B();
            b.F();
            A a = b;
            a.F();
            a.H();
            Console.ReadKey();
        }
    }
}
