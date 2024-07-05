namespace TASK_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 4");
            Console.WriteLine("Podaj rok: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"Podany rok {year} jest rokiem przestępnym!");
            }
            else
            {
                Console.WriteLine($"Podany rok {year} nie jest rokiem przestępnym!");
            }
        }
    }
}