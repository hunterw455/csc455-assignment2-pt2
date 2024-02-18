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
                MenuOptions menuChoice = new MenuOptions();
                
                //  Display menu and get user input
                menuChoice.displayMenu();
                string userInput = Console.ReadLine();
                Console.WriteLine("Input a string of your choice.");
                string userString1 = Console.ReadLine();
                Console.WriteLine("Input another string of your choice.");
                string userString2 = Console.ReadLine();

                string str = menuChoice.processChoice(userInput, userString1, userString2);
                Console.WriteLine(str);

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
 
    }

    //  Class of menu options
    public class MenuOptions
    {
        public void displayMenu()
        {
            Console.WriteLine("Choose a feature you'd like this program to run by entering a number between 1 and 4.");
            Console.WriteLine("     1 - Random Positive Integer Between 1 And 10");
            Console.WriteLine("     2 - Output Today's Date In Short Date String");
            Console.WriteLine("     3 - Output A Random Dinosaur Name");
            Console.WriteLine("     4 - Perform A Random Action On A String");
        }

        //  Takes in the user's choice and does an if statement to call the functions
        public string processChoice(string str, string userString1, string userString2)
        {
            string outPut = "";
            switch(str){
                case "1":
                    outPut = randomInt();
                    return outPut;
                case "2":
                    outPut = displayShortDate();
                    return outPut;
                case "3":
                    outPut = printRandomDino();
                    return outPut;
                case "4":
                    outPut = randomStringAction(userString1, userString2);
                    return outPut;
                default:
                    outPut = "Input a valid integer number between 1 and 4.";
                    return outPut;
            }
        }

        //  Displays a random integer based on the user's input
        static string randomInt()
        {
            Random randomNum = new Random();
            string str = "Here is a random integer number between 1 and 10: " + randomNum.Next(1, 11) + ".";
            return str;
        }

        //  Displays today's date in short date string
        static string displayShortDate()
        {
            DateTime todayDate = DateTime.Now;
            string shortDate = todayDate.ToShortDateString();
            string str = "Today's date is " + shortDate + ".";
            return str;
        }

        static string printRandomDino()
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
            string str = "Here is a random dinosaur name: " + dinosaurNames[randomDino] + ".";
            return str;
        }

        //  Performs a random string action
        static string randomStringAction(string userString, string userString2)
        {
            StringActions performString = new StringActions();

            Random randomNum = new Random();
            int randomAction = randomNum.Next(1, 11);

            string str = "";

            //  If statements to perform a random action on a string the user inputs
            if (randomAction == 1)
            {
                str = "Your fist string in reverse is: " + performString.reverseString(userString) + ".";
            }
            else if (randomAction == 2)
            {
                str = "The length of your first string is: " + performString.getLength(userString) + ".";
            }
            else if (randomAction == 3)
            {
                str = "Half of your first string is: " + performString.getHalf(userString) + ".";
            }
            else if (randomAction == 4)
            {
                str = "Your first string in all uppercase values is: " + userString.ToUpper() + ".";
            }
            else if (randomAction == 5)
            {
                str = "If we replace any letter e with an _, your first string will look like: " + performString.replaceE(userString) + ".";
            }
            else if (randomAction == 6)
            {
                str = "The hash code of your first string is: " + userString.GetHashCode() + ".";
            }
            else if (randomAction == 7)
            {
                str = "Your first string in all lowercase values is: " + userString.ToLower() + ".";
            }
            else if (randomAction == 8)
            {
                str = "Your two strings together are: " + performString.concatenate(userString, userString2) + ".";
            }
            else if (randomAction == 9)
            {
                str = "You have " + performString.countWords(userString) + " word(s) in your first string.";
            }
            else if (randomAction == 10)
            {
                str = "You have " + performString.countSpaces(userString) + " spaces in your first string.";
            }
            
            return str;
        }
    }



    //  Class of string actions for function 4 to use
    public class StringActions
    {
        //  Reverses the string
        public string reverseString(string str)
        {
            char[] reverseArray = str.ToCharArray();
            Array.Reverse(reverseArray);
            str = new string(reverseArray);
            return str;
        }

        public int getLength(string str)
        {
            return str.Length;
        }

        public string getHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }

        public string replaceE(string str)
        {
            str = str.Replace("e", "_");
            str = str.Replace("E", "_");
            return str;
        }

        public string concatenate(string str, string str2)
        {
            str = string.Concat(str, str2);
            return str;
        }

        public int countWords(string str)
        {
            int words = Regex.Matches(str, @"\b\w+\b").Count;
            return words;
        }

        public int countSpaces(string str)
        {
            char[] strArray = str.ToCharArray();
            int count = 0;
            foreach (char c in strArray)
            {
                if (char.IsWhiteSpace(c))
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
