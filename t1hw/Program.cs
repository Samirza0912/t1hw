using System;

namespace t1hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter month's name :");
            string month = Console.ReadLine();
            if ((month == "january") || (month == "february") || (month == "december"))
            {
                Console.WriteLine("winter");
            }
            else if ((month == "march") || (month == "april") || (month == "may"))
            {
                Console.WriteLine("spring");
            }
            else if ((month == "june") || (month == "july") || (month == "august"))
            {
                Console.WriteLine("summer");
            }
            else if ((month == "september") || (month == "october") || (month == "november"))
            {
                Console.WriteLine("autumn");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
