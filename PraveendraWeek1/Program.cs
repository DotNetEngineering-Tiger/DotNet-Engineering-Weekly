namespace PraveendraWeek1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Name: ");

        string name = Console.ReadLine();

        Console.WriteLine($"Hello, World! This is {name}");

        Console.WriteLine("Please Enter Your Age");

        string age = Console.ReadLine();

        int ageInNumber = Convert.ToInt32(age);

        Console.WriteLine($"I am {ageInNumber}");

        Console.WriteLine($"Next Year I will be {ageInNumber + 1}.");

    }
}
