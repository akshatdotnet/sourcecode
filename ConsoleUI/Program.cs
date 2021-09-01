using System;

namespace ConsoleUI
{
    class Program
    {
        //singleton design pattern
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singlton obj1 = Singlton.MyObject();
            obj1.mymethod();
            Singlton obj2 = Singlton.MyObject();
            obj2.mymethod();
            Console.ReadLine();
        }
    }

    sealed class Singlton
    {
        private Singlton()
        {

        }
        public static Singlton getinstnace = null;
        public static Singlton MyObject()
        {
            if (getinstnace == null)
            {
                return new Singlton();
            }
            return getinstnace;
        }
        public void mymethod()
        {
            Console.WriteLine("This is my Method");
        }
    }
}
