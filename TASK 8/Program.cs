using System;

namespace TASK_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 8");
            Console.WriteLine("Aby zostać dopuszczony wynik z trzech przedmiotów musi wynosić 180 lub z matematyki i jednego przedmiotu powyżej 150.");
            Console.WriteLine("Podaj swój wynik z matematyki w %.");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wynik z fizyki w %.");
            int score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wynik z chemii w %.");
            int score2 = int.Parse(Console.ReadLine());

            if (score > 70 && score1 > 55 && score2 > 45)
            {
                Console.WriteLine("Gratulacje! Kandydat dopuszczony do rekrutacji!");
            }
            else if (score + score1 + score2 > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji!");
            }
            else if (score + score1 > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji!");
            }
            else if (score + score2 > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji!");
            }
            else
            {
                Console.WriteLine("Zbyt mały wynik kandydat nie zostaje dopuszczony do rekrutacji!");
            }
        }
    }
}