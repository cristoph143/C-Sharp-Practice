using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Literals.literals();
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey(); // wait for user to press anything
        }
    }

    public class Literals {
        public static void literals() {
            int i = 0;
            long l = 0L;
            float f = 0.0F;
            double d = 0.0D;
            decimal m = 0.0M;
            string s = "Hello World";
            char c = 'c';
            bool b = true;
            object o = new object();
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("l = {0}", l);
            Console.WriteLine("f = {0}", f);
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("m = {0}", m);
            Console.WriteLine("s = {0}", s);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("o = {0}", o);
        }
    }
}