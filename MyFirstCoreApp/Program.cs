using System;

namespace MyFirstCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Представьтесь, пожалуйста!");
            string str = Console.ReadLine();
            Console.WriteLine("Привет, " + str + "!");
            Console.Read();
            Console.Clear();
        }
    }
}
