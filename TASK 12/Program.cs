namespace TASK_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TASK 12");
            Console.WriteLine("Podaj liczbe od 1 do 7 aby wyświetlić dzień tygodnia.");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie poprawna liczba");
                    break;


            }
        }
    }
}
