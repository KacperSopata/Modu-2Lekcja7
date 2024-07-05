namespace TASK_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TASK 6");
            Console.WriteLine("Podaj swój wzrost w cm: ");
            int hight = int.Parse(Console.ReadLine());
            if (hight <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (hight <= 160)
            {
                Console.WriteLine("Jesteś wyrośniętym krasnoludem.");
            }
            else if (hight <= 180)
            {
                Console.WriteLine("Jesteś w standardowym wzroście.");
            }
            else if (hight <= 190)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else if (hight <= 200)
            {
                Console.WriteLine("Jesteś bardzo wysoki.");
            }
            else
            {
                Console.WriteLine("Poza skalą.");
            }
        }
    }
}
