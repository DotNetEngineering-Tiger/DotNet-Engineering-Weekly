namespace PraveendraWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 14;
            double expenses = 501.26;
            string name = "Praveendra";
            bool question = false;

            Console.WriteLine($"My name is {name} and in {days} days, my expenses is {expenses} dollars.");
            Console.WriteLine($"Is that true? {question}");

            string String1 = "Dirty Dreams Done Dirt Cheap";
            var word = "  Deeds  ";
            word = word.Trim();
            string String2 = String1.Replace("Dreams", word);
            int input = 100;
            string convertedToString = Convert.ToString(input);

            Console.WriteLine(String2 + " X " + convertedToString);

            
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your weekly expenses: ");
            double userexpenses = Convert.ToDouble(Console.ReadLine());
            double dailyexpenses = userexpenses/7;
            int Round = Convert.ToInt32(dailyexpenses);
            double YearExpenses = dailyexpenses*365;
            int YearExpenses1 = Convert.ToInt32(YearExpenses);

            Console.WriteLine($"Hello {userName},your daily expenses is around {Round} dollars.");
            Console.WriteLine($"Your yearly expenses amount to {YearExpenses1} dollars.");
        }
    }
}

