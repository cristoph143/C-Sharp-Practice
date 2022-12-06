using System;

namespace MyNamespace
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await Basics.basic();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); // wait for user to press anything
        }
    }
}