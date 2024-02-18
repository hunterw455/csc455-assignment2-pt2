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
            string str = menuOptions.processChoice("2", "", "");
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
            string str = menuOptions.processChoice("3", "", "");
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
        [DataRow("", "", "")]
        [DataRow(" ", "", "")]
        [DataRow("34", "", "")]
        [DataRow("\t", "", "")]
        [DataRow("-10000000000000000000000000000000000", "", "")]
        public void testMethodInvalidInputs(string input, string input1, string input2)
        {
            //  Arrange
            string expected = "Input a valid integer number between 1 and 4.";
            MenuOptions menuOptions = new MenuOptions();
            //  Act
            string str = menuOptions.processChoice(input, input1, input2);
            //  Assert
            Assert.IsTrue(str.Contains(expected));
        }

        //  Data test method to test the reverse string action
        [DataTestMethod]
        [DataRow("hello", "olleh")]
        [DataRow("apples and bananas", "sananab dna selppa")]
        [DataRow("Hello World", "Hello World")] // Will intentionally fail the test
        public void testStringActionReverseString(string str, string expected)
        {
            //  Arrange
            StringActions stringAction = new StringActions();
            //  Act
            str = stringAction.reverseString(str);
            //  Assert
            Assert.AreEqual(str, expected);
        }

        [DataTestMethod]
        [DataRow("hello", "h_llo")]
        [DataRow("eeee", "____")]
        [DataRow("Elizabeth has eleven elves in her elm tree", "_lizab_th has _l_v_n _lv_s in h_r _lm tr__")]
        [DataRow("Everyone", "Ev_ryon_")] // Will intentionally fail the test
        public void testStringActionReplaceE(string str, string expected)
        {
            //  Arrange
            StringActions stringAction = new StringActions();
            //  Act
            str = stringAction.replaceE(str);
            //  Assert
            Assert.AreEqual(str, expected);
        }

        [DataTestMethod]
        [DataRow("Hello ", "World", "Hello World")]
        [DataRow("What's the object oriented way to become wealthy?", " Inheritance.", "What's the object oriented way to become wealthy? Inheritance.")]
        [DataRow("Testing is", " fun...", "testing is fun..")] // Will intentionally fail the test because the expected has one less .
        public void testStringActionConcatenate(string str1, string str2, string expected)
        {
            //  Arrange
            StringActions stringAction = new StringActions();
            //  Act
            string concatenate = "";
            concatenate = stringAction.concatenate(str1, str2);
            //  Assert
            Assert.AreEqual(concatenate, expected);
        }

        [DataTestMethod]
        [DataRow("Count the words in this sentence.", 7)] // Will intentionally fail, as there are 6 words in the sentence
        [DataRow("hello world", 2)]
        [DataRow("hello", 1)]
        [DataRow("", 0)]
        [DataRow("\t", 0)]
        public void testStringActionCountWords(string str, int actualCount)
        {
            //  Arrange
            StringActions stringActions = new StringActions();
            //  Act
            int count = stringActions.countWords(str);
            //  Assert
            Assert.AreEqual(count, actualCount);
        }

        [DataTestMethod]
        [DataRow("Elizabeth has eleven elves in her elm tree", 7)]
        [DataRow("Hello World", 1)]
        [DataRow("", 0)]
        [DataRow("\t",0)] // Will intentionally fail the test as tab creates white space
        public void testStringActionCountSpaces(string str, int actualCount)
        {
            //  Arrange
            StringActions stringActions = new StringActions();
            //  Act
            int count = stringActions.countSpaces(str);
            //  Assert
            Assert.AreEqual(count, actualCount);
        }
    }
}

