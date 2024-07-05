namespace TASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Podana liczba {number} jest liczbą parzystą!");
            }
            else
            {
                Console.WriteLine($"Podana liczba {number} nie jest liczbą parzystą!");
            }
        }
    }
}
