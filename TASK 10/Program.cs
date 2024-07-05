namespace TASK_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 10");
            Console.WriteLine("Podaj pierwsza długośc trójkąta: ");
            int bok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą długośc trójkąta: ");
            int bok1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią długośc trójkąta: ");
            int bok2 = int.Parse(Console.ReadLine());

            if(bok + bok1 > bok2 && bok + bok2 > bok1 && bok1 + bok2 > bok)
            {
                Console.WriteLine($"Z podanych długości {bok}, {bok1}, {bok2} można stowrzyć trójkąt!");
            }
            else
            {
                Console.WriteLine($"Z podanych długości {bok}, {bok1}, {bok2} nie można stworzyć trójkąta!");
            }
        }
    }
}
