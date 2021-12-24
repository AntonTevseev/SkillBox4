using System;
using static System.Console;
namespace sas
{
    class Program
    {
        static void Main(string[]ages)
        {
            int a = int.Parse(ReadLine());

            if (a % 2 != 0)
            {
                for (int i = 2; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine("не простое");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("простое");
                        break;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("не простое");
            }
            Console.ReadLine();
        }
    }
}