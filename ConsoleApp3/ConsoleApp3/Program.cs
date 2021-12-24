using System;
using static System.Console;
namespace xui
{
    class Program
    {
        static void Main(string[] agre)
        {
            WriteLine("введите число: ");
            int num = int.Parse(ReadLine());
            for (; ; )
            {
                if (num % 2 == 0)
                {
                    WriteLine("число чётное");
                    break;
                }
                else
                    WriteLine("число не чётное");
                    break ;
            }
        }
    }
}
