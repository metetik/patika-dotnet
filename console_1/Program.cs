using System;

namespace console_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin : ");
            string name = Console.ReadLine();
            Console.WriteLine("Selam, " + name);
        }
    }
}