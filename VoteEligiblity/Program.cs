using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteEligiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input 1st number") ; 
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Input 2nd number");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Input 3rd number");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
                Console.WriteLine("" + number1 + " is maximum than " + number2 + " and " + number3 + "");
            else if (number2 > number1 && number2 > number3)
                Console.WriteLine("" + number2 + " is maximum than " + number1 + " and " + number3 + "");
            else if (number3 > number1 && number3 > number2)
                Console.WriteLine("" + number3 + " is maximum than " + number1 + " and " + number2 + "");
            else
                Console.WriteLine("" + number1 + "," + number2 + " and " + number3 + " are equal");


            Console.WriteLine("Thank you");
            Console.ReadKey();
        }
    }
}
