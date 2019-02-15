using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsGivenNumLowerOrBigger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5, test class

namespace IsGivenNumLowerOrBigger.Tests
{
    [TestClass()]
    public class GivenNumLowerOrBiggerTests
    {
        [TestMethod()]
        public void GivenNumLowerOrBiggerTest1()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 45, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 0);
            string expected = "has only one smaller neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest2()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 45, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 0);
            string expected = "has only one bigger neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest3()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 45, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, numArray.Length - 1);
            string expected = "has only one bigger neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest4()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 45, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, numArray.Length - 1);
            string expected = "has only one smaller neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest5()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 8, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, numArray.Length - 1);
            string expected = "has only one equal neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest6()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 8, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, numArray.Length - 1);
            string expected = "has only one smaller neighbor.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest7()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 6);
            string expected = "is greater than it's two neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest8()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 6);
            string expected = "is smaller than it's two neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest9()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 7);
            string expected = "is smaller than it's two neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest10()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 7);
            string expected = "is greater than it's two neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest11()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 8);
            string expected = "is greater than one but less than the other neighboring number.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest12()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 8, 9, 3, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 7);
            string expected = "is greater than one but less than the other neighboring number.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest13()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 9, 9, 9, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 6);
            string expected = "is equal to one or both of its neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumLowerOrBiggerTest14()
        {
            int[] numArray = { 6, 1, 1, 2, 4, 9, 9, 9, 14, 25, 1, 2, 15, 8 };
            string actual = Program.FindLargerOrSmaller(numArray, 7);
            string expected = "is equal to one or both of its neighboring numbers.";
            Assert.AreEqual(expected, actual);
        }

    }
}