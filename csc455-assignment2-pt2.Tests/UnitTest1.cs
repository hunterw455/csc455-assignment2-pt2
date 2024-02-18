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

        //  Tests if the user inputs an invalid input
        [TestMethod]
        public void testMethodInvalidInput1()
        {
            //  Arrange
            string expected = "Input a valid integer number between 1 and 4.";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice("");
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

    }
}

