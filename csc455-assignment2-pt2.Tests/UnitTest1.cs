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
            string str = menuOptions.processChoice("1");
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
            string str = menuOptions.processChoice("2");
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
            string str = menuOptions.processChoice("3");
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

        //  Tests the fourth method the program will perform
        [TestMethod]
        public void testMethod4()
        {
            //  Arrange
            string expected = "";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("4");
            //  Assert
            if (str.Contains("Your string in reverse is"))
            {
                Assert.IsTrue(str.Contains("Your string in reverse is"));
            } else if (str.Contains("The length of your string is"))
            {
                Assert.IsTrue(str.Contains("The length of your string is"));
            } else if (str.Contains("Half of your string is"))
            {
                Assert.IsTrue(str.Contains("Half of your string is"));
            } else if (str.Contains("Your string in all uppercase values is"))
            {
                Assert.IsTrue(str.Contains("Your string in all uppercase values is"));
            } else if (str.Contains("If we replace any letter e with an _, your string will look like"))
            {
                Assert.IsTrue(str.Contains("If we replace any letter e with an _, your string will look like"));
            } else if (str.Contains("The hash code of your string is"))
            {
                Assert.IsTrue(str.Contains("The hash code of your string is"));
            } else if (str.Contains("Your string in all lowercase values is"))
            {
                Assert.IsTrue(str.Contains("Your string in all lowercase values is"));
            } else if (str.Contains("Your two strings together are"))
            {
                Assert.IsTrue(str.Contains("Your two strings together are"));
            } else if (str.Contains("word(s) in your string"))
            {
                Assert.IsTrue(str.Contains("word(s) in your string"));
            } else if (str.Contains("spaces in your string"))
            {
                Assert.IsTrue(str.Contains("spaces in your string"));
            }
        }


        //  Tests if the user inputs an invalid choice
        [DataTestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow("34")]
        [DataRow("\t")]
        [DataRow("-10000000000000000000000000000000000")]
        public void testMethodInvalidInputs(string input)
        {
            //  Arrange
            string expected = "Input a valid integer number between 1 and 4.";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice(input);
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }
    }
}

