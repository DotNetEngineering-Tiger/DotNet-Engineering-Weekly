namespace SampleProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating an example for double
            double kiloMeter = 4;
            double mileToKiloMeter = 1.61;
            double numberOfMiles = kiloMeter/mileToKiloMeter;

            Console.WriteLine($"There is {mileToKiloMeter} km in a mile, which means in {kiloMeter} km there is {numberOfMiles} miles.");

            //Creating trim()
            string firstName = "   Pema";
            string lastName = "               Dukpa ";
            Console.WriteLine($"My name is {firstName.TrimStart()} {lastName.Trim()}.");

            //Creating replaced
            string dateEntry = "Last year on 3/28/22, I went on a vacation.";
            string correctDateEntry = dateEntry.Replace("3/28/22", "3/28/23");
            Console.WriteLine(correctDateEntry);

            //Creating int to double
            int country = 195;
            double countries = (double)country;
            Console.WriteLine(countries);

            //Creating string to int and double
            string firstInput = "68";
            string secondInput = "439.56";
            double convertToDouble = Convert.ToDouble(secondInput);
            Console.WriteLine($"There are only {Convert.ToInt32(firstInput)} pieces of fish in {convertToDouble} pound.");

            //Creating double to int
            double doubleValue = 48.56;
            int intValue = Convert.ToInt32(doubleValue);
            Console.WriteLine(intValue);

            //Creating string to float
            string initialValue = "34.6";
            float floatValue = float.Parse(initialValue);
            Console.WriteLine(floatValue);  

        }
    }
}
