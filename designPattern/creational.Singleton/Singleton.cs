using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Usage
    {
        public static void Main()
        {
            var instance = Singleton.Instance;
            instance.GetDataBaseObject();
        }
    }
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private static readonly object padlock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void GetDataBaseObject()
        {
            Console.WriteLine("Connecting to DataBase");
        }

    }
}
