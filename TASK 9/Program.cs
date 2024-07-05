
namespace TASK_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 9");
            Console.WriteLine("Podaj twoja obecna temperature: ");
            int temp = int.Parse(Console.ReadLine());
            if (temp < 0)
            {
               Console.WriteLine("Cholernie piździ!");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Zimno.");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Chłodno.");
            }
            else if (temp < 30)
            {
                Console.WriteLine("W sam raz.");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę.");
            }
        }
    }
}
