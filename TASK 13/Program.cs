namespace TASK_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 13");
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Podaj pierwszą liczbe:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz metode: ");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Wyjście z programu");

            int score = 0; 
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    score = number + number1;
                    break;
                case "2":
                    score = number - number1;
                    break;
                case "3":
                    score = number * number1;
                    break;
                case "4":
                    if (number1 == 0)
                    {
                        Console.WriteLine("Błąd. Nie można dzielić przez zero!");
                        break;
                    }
                    score = number / number1;
                    break;
                case "5":
                    Console.WriteLine("Dziękuje za skorzystanie z programu");
                    break;
                default:
                    Console.WriteLine("Wybrano nie poprawną metode");
                    break;
            }
            Console.WriteLine($"Wynik twojego działania to: {score}");
        }
    }
}