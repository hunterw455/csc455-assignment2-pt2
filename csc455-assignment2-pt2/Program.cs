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
            bool resumeProgram = true;
            
            //  Loop to run through the program
            do
            {
                //  Display menu and get user input
                displayMenu();
                string userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    randomInt();
                } else if(userInput == "2")
                {
                    displayShortDate();
                } else if(userInput == "3")
                {
                    printRandomDino();
                }

                Console.WriteLine("Would you like to try again?  Y/N");
                userInput = Console.ReadLine();
                
                if(userInput == "N" || userInput == "n")
                {
                    resumeProgram = false;
                    break;
                }
            }
            while (resumeProgram);
            
            
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

        static void printRandomDino()
        {
            //  Create a list of 10 dinosaur names, sort, and print one at random
            //  Source: https://www.thoughtco.com/the-dinosaur-encyclopedia-1091968
            List<string> dinosaurNames = new List<string>();
            dinosaurNames.Add("Tyrannosaurus Rex");
            dinosaurNames.Add("Triceratops");
            dinosaurNames.Add("Velociraptor");
            dinosaurNames.Add("Stegosaurus");
            dinosaurNames.Add("Spinosaurus");
            dinosaurNames.Add("Archaeopteryx");
            dinosaurNames.Add("Brachiosaurus");
            dinosaurNames.Add("Allosaurus");
            dinosaurNames.Add("Apatosaurus");
            dinosaurNames.Add("Dilophosaurus");

            //Orders the list by name
            dinosaurNames = dinosaurNames.OrderBy(p => p).ToList();

            Random randomNum = new Random();
            int randomDino = randomNum.Next(0, 10);

            Console.WriteLine("Here is a random dinosaur name: {0}", dinosaurNames[randomDino]);
        }
    }
}
