namespace TASK_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 7");
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number == number1 && number == number2)
            {
                Console.WriteLine($"Wszystkie podane liczby: {number}, {number1}, {number2}, są takie same.");
            }
            else if (number > number1 && number > number2)
            {
                Console.WriteLine($"Podana liczba {number} jest największa z pośród liczb {number}, {number1}, {number2}");
            }
            else if (number1 > number && number1 > number2)
            {
                Console.WriteLine($"Podana liczba {number1} jest największa z pośród liczb {number}, {number1}, {number2}");
            }
            else
            {
                Console.WriteLine($"Podana liczba {number2} jest największa z pośród liczb {number}, {number1}, {number2}");

            }
        }
    }
}