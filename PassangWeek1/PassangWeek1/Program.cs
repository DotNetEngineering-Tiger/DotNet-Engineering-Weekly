namespace PassangWeek1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            //Read User input
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, World! This is {name}");

            Console.WriteLine("Please enter your Age");

            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I am {Age}");

            Console.WriteLine($"Next year I will be {Age + 1}");
        }
    }
}



