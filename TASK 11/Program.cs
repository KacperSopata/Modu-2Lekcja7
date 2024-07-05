namespace TASK_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 11");
            Console.WriteLine("Podaj ocene:  ");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostatecznuy");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo Dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie poprawna liczba");
                    break;
            }
        }
    }
}
