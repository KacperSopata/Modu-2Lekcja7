namespace TASK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 3");

            Console.WriteLine("Podaj liczbe: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"Podana liczba {number} jest liczbą dodatnią!");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Podana liczba {number} nie jest liczbą dodatnią!");
            }
            else if (number == 0)
            {
                Console.WriteLine("Podana liczba jest nie zalicza się do grona liczb dodatnich i ujemnych!");
            }
        }
    }
}
