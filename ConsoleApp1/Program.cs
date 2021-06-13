using System;

namespace ConsoleApp1
{
    class Program
    {
        static void HelloWorld(string name)
        {
            Console.WriteLine($"Hello {name} World!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            HelloWorld(name);
        }
    }
}
