//  Assignment 1 - Program performs 4 different features based on the user's input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csc455_assignment2_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Display menu and get user input
            displayMenu();
            string userInput = Console.ReadLine();
            
            
            //  Used so the cmd didn't exit quickly
            Console.ReadLine();
        }

        static void displayMenu()
        {
            Console.WriteLine("Choose a feature you'd like this program to run by entering a number between 1 and 4.");
            Console.WriteLine("     1 - Random Positive Integer Between 1 And 10");
            Console.WriteLine("     2 - Output Today's Date In Short Date String");
            Console.WriteLine("     3 - Output A Random Dinosaur Name");
            Console.WriteLine("     4 - Perform A Random Action On A String");
        }

        //  Displays a random integer based on the user's input
        static void randomInt()
        {
            Random randomNum = new Random();
            Console.WriteLine("Here is a random integer number between 1 and 10: {0}", randomNum.Next(1, 11));
        }

        //  Displays today's date in short date string
        static void displayShortDate()
        {
            DateTime todayDate = DateTime.Now;
            string shortDate = todayDate.ToShortDateString();
            Console.WriteLine("Today's date is {0}.", shortDate);
        }
    }
}
