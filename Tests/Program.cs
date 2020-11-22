using System;
using OpaRoller.Models;
using OpaRoller.Controllers;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск тестов...");
            Console.WriteLine("BasicD6:");
            for (int i = 0; i < 15; i++)
            {
                BasicD6();
            }
            Console.WriteLine("BasicD4:");
            for (int i = 0; i < 15; i++)
            {
                BasicD4();
            }

        }

        static void BasicD6()
        {
            D6 d6 = new D6();
            var result = Roller.Roll(2, d6);
            Console.WriteLine($"Result: {result[0]}, {result[1]}");

        }

        static void BasicD4()
        {
            D4 d4 = new D4();
            var result = Roller.Roll(2, d4);
            Console.WriteLine($"Result: {result[0]}, {result[1]}");
        }
    }
}
