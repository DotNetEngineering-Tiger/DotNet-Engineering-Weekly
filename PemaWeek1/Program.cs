namespace PemaWeek1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Yur Name: ");

            //Read user input
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, World! This is {name}");

            Console.WriteLine("Please Enter Your Age: ");

            //Read user Input

            string age = Console.ReadLine();

            int ageInNumber = Convert.ToInt32(age);

            Console.WriteLine($"I am {ageInNumber}");

            Console.WriteLine($"Next year I will be {ageInNumber + 1}");

        }
    }
}

