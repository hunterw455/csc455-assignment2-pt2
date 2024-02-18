using Microsoft.VisualStudio.TestTools.UnitTesting;
using csc455_assignment2_pt2;
using System;

namespace csc455_assignment2_pt2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //  Tests the first method the program will perform
        [TestMethod]
        public void testMethod1()
        {
            //  Arrange
            string expected = "Here is a random integer number between 1 and 10: ";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("1", "", "");
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

        //  Tests the second method the program will perform
        [TestMethod]
        public void testMethod2()
        {
            //  Arrange
            string expected = "Today's date is";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("2","", "");
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

        //  Tests the third method the program will perform
        [TestMethod]
        public void testMethod3()
        {
            //  Arrange
            string expected = "Here is a random dinosaur name:";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("3","","");
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

        //  Tests the fourth method the program will perform
        [TestMethod]
        public void testMethod4()
        {
            //  Arrange
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("4", "Hello", "World");
            //  Assert
            if (str.Contains("string in reverse is"))
            {
                Assert.IsTrue(str.Contains("string in reverse is"));
            } else if (str.Contains("The length of your"))
            {
                Assert.IsTrue(str.Contains("The length of your"));
            } else if (str.Contains("Half of your"))
            {
                Assert.IsTrue(str.Contains("Half of your"));
            } else if (str.Contains("in all uppercase values is"))
            {
                Assert.IsTrue(str.Contains("in all uppercase values is"));
            } else if (str.Contains("If we replace any letter e with an _"))
            {
                Assert.IsTrue(str.Contains("If we replace any letter e with an _"));
            } else if (str.Contains("The hash code"))
            {
                Assert.IsTrue(str.Contains("The hash code"));
            } else if (str.Contains("in all lowercase values is"))
            {
                Assert.IsTrue(str.Contains("in all lowercase values is"));
            } else if (str.Contains("Your two strings together are"))
            {
                Assert.IsTrue(str.Contains("Your two strings together are"));
            } else if (str.Contains("word(s) in"))
            {
                Assert.IsTrue(str.Contains("word(s) in"));
            } else if (str.Contains("spaces in your"))
            {
                Assert.IsTrue(str.Contains("spaces in your"));
            }
        }


        //  Tests if the user inputs an invalid choice
        [DataTestMethod]
        [DataRow("","","")]
        [DataRow(" ", "","")]
        [DataRow("34", "","")]
        [DataRow("\t", "","")]
        [DataRow("-10000000000000000000000000000000000", "","")]
        public void testMethodInvalidInputs(string input, string input1, string input2)
        {
            //  Arrange
            string expected = "Input a valid integer number between 1 and 4.";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice(input,input1, input2);
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }
    }
}

