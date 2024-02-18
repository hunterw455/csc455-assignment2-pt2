//  Assignment 1 - Program performs 4 different features based on the user's input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
                } else if (userInput == "4")
                {
                    randomStringAction();
                }
                else
                {
                    Console.WriteLine("Input a valid integer number between 1 and 4.");
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

            //  Orders the list by name
            dinosaurNames = dinosaurNames.OrderBy(p => p).ToList();

            Random randomNum = new Random();
            int randomDino = randomNum.Next(0, 10);

            Console.WriteLine("Here is a random dinosaur name: {0}", dinosaurNames[randomDino]);
        }

        //  Performs a random string action
        static void randomStringAction()
        {
            Console.WriteLine("Input a string of your choice.");
            string userString = Console.ReadLine();

            Random randomNum = new Random();
            int randomAction = randomNum.Next(1, 11);

            //  If statements to perform a random action on a string the user inputs
            if (randomAction == 1)
            {
                //  Reverses the string
                char[] reverseArray = userString.ToCharArray();
                Array.Reverse(reverseArray);
                string reversedString = new string(reverseArray);
                Console.Write("Your string in reverse is: {0}", reversedString);
            }
            else if (randomAction == 2)
            {
                //  Outputs length of string
                Console.Write("The length of your string is: {0}", userString.Length);
            }
            else if (randomAction == 3)
            {
                //  Ouputs half the string
                Console.WriteLine("Half of your string is: {0}", userString.Substring(0, userString.Length / 2));
            }
            else if (randomAction == 4)
            {
                //  Outputs the uppercase values of the string
                Console.Write("Your string in all uppercase values is: {0}", userString.ToUpper());
            }
            else if (randomAction == 5)
            {
                //  Replaces any e with _
                userString = userString.Replace("e", "_");
                Console.WriteLine("If we replace any letter e with an _, your string will look like: {0}", userString);
            }
            else if (randomAction == 6)
            {
                //  Outputs the hash code of a string
                Console.WriteLine("The hash code of your string is: {0}", userString.GetHashCode());
            }
            else if (randomAction == 7)
            {
                //  Outputs the lowercase values of the string
                Console.WriteLine("Your string in all lowercase values is: {0}", userString.ToLower());
            }
            else if (randomAction == 8)
            {
                //  Concatenates two strings
                Console.WriteLine("Input another string.");
                string str2 = Console.ReadLine();
                userString = string.Concat(userString, str2);
                Console.WriteLine("Your two strings together are: {0}", userString);
            }
            else if (randomAction == 9)
            {
                //  Checks how many words are in the string provided
                int words = Regex.Matches(userString, @"\b\w+\b").Count;
                Console.WriteLine("You have {0} word(s) in your string.", words);
            }
            else if (randomAction == 10)
            {
                //  Checks how many spaces are in the string
                char[] strArray = userString.ToCharArray();
                int count = 0;
                foreach (char c in strArray)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        count += 1;
                    }
                }
                Console.WriteLine("You have {0} spaces in your string.", count);
            }
        }
    }
}
