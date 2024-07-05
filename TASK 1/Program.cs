namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            Console.WriteLine("Podaj pierwszą liczbe:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe:");
            int number1 = int.Parse(Console.ReadLine());
            if (number == number1)
            {
                Console.WriteLine($"Podane liczby {number} i {number1} są takie same!");
            }
            else
            {
                Console.WriteLine($"Niestety podane liczby {number} i {number1} nie są takie same!");
            }
        }
    }
}
