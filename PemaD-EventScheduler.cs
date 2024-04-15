using System.Runtime.CompilerServices;

namespace PemaD_EventSchedulerandTimeManagerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //1. User Input

            Console.WriteLine("Please enter the current day of the week: ");
            var inputDay = Console.ReadLine();

            Console.WriteLine("Please enter a time: ");
            var inputTime = Convert.ToInt32(Console.ReadLine());

         //2. Conditional Logic: Use if-else

            if (inputDay.Equals("Monday", StringComparison.CurrentCultureIgnoreCase) && inputTime <= 12)
            {
                Console.WriteLine("Morning briefing at 9AM");
            }

            else if (inputDay.Equals("Monday", StringComparison.CurrentCultureIgnoreCase) && inputTime > 12)
            {
                Console.WriteLine("Project work time");
            }

            else if (inputDay.Equals("Monday", StringComparison.CurrentCultureIgnoreCase) && inputTime == 15)
            {
                Console.WriteLine("Weekly review meeting");
            }

            //3.Error Handling:

            else
            {
                Console.WriteLine("Invalid input, please try again!")
            }




        }
    }
}
