using System;
using static System.Console;
namespace xuy
{
    class Program
    {
        static void Main(string[] ages)
        {
            Console.Write("Здраствуйте, введите количество карт у вас на руках : ");
            int countCard = int.Parse(Console.ReadLine());

            int sumCard = 0;

            for (int i = 0; i < countCard; i++)
            {
                Console.WriteLine($"Возможные числовые карты от 6 до 10");
                Console.WriteLine($"J = Валет, Q = Дама, K = Король, T = Туз, = 10");
                Console.Write($"Введите номинал для {i + 1} карты : ");
                string whatCard = Console.ReadLine();

                switch (whatCard)
                {
                    case "J":
                        sumCard += 10;
                        break;
                    case "Q":
                        sumCard += 10;
                        break;
                    case "K":
                        sumCard += 10;
                        break;
                    case "T":
                        sumCard += 10;
                        break;
                    case "6":
                        sumCard += 6;
                        break;
                    case "7":
                        sumCard += 7;
                        break;
                    case "8":
                        sumCard += 8;
                        break;
                    case "9":
                        sumCard += 9;
                        break;
                    case "10":
                        sumCard += 10;
                        break;
                }
            }
            if (sumCard > 21)
            {
                Console.WriteLine("Не превышайте значение высше 21");
                Console.WriteLine($"Значение суммы карт = {sumCard}");
            }
            else
            {
                Console.WriteLine($"Значение суммы карт = {sumCard}");
            }
        }
    }
}
