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
            Console.WriteLine("Please Input a day number") ; 
            string number1 = Console.ReadLine();

            switch (number1)
            {
                case "1":
                    Console.WriteLine("Saturday");
                    break;
                case "2":
                    Console.WriteLine("Sun Day");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            Console.ReadKey();
        }
    }
}
