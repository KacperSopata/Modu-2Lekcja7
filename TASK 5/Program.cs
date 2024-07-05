namespace TASK_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 5");
            Console.WriteLine("Podaj swój wiek: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 35)
            {
                Console.WriteLine("Gratulacje! Twój wiek jest odpowiedni, możesz zostać posłem, premierem, senatorem oraz prezydentem.");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Gratulacje! Twój wiek jest odpowiedni, możesz zostać posłem, premierem oraz senatorem.");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Gratulacje! Twój wiek jest odpowiedni, możesz zostać posłem lub premierem.");
            }
            else
            {
                Console.WriteLine("Niestety jesteś za młody, żeby zostać posłem, premierem, senatorem lub prezydentem.");
            }
        }
    }
}