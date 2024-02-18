using Microsoft.VisualStudio.TestTools.UnitTesting;
using csc455_assignment2_pt2;
using System;

namespace csc455_assignment2_pt2.Tests
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}

