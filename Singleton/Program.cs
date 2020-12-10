using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance();
            Console.WriteLine(Singleton.Instance());

        }
    }
    class Singleton
    {
        static Singleton instance = null;
        protected Singleton() { }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }

}
