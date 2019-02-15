using Microsoft.VisualStudio.TestTools.UnitTesting;
using GivenNumInArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4, test class

namespace GivenNumInArray.Tests
{
    [TestClass()]
    public class GivenNumInArrayTests
    {
        [TestMethod()]
        public void GivenNumInArrayTest1()
        {
            int[] numArray = { 1, 2, 2, 1, 3, 5, 6, 7, 4, 4, 2, 3, 6 };
            int actual = GivenNumInArray.FindNum(6, numArray);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumInArrayTest2()
        {
            int[] numArray = { 1, 2, 2, 1, 3, 5, 6, 7, 4, 4, 2, 3, 6 };
            int actual = GivenNumInArray.FindNum(6, numArray);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumInArrayTest3()
        {
            int[] numArray = { 4, 6, 9, 1, 1, 2, 1, 6, 1, 18, 96, 32, 5, 1, };
            int actual = GivenNumInArray.FindNum(1, numArray);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivenNumInArrayTest4()
        {
            int[] numArray = { 4, 6, 9, 1, 1, 2, 1, 6, 1, 18, 96, 32, 5, 1, };
            int actual = GivenNumInArray.FindNum(1, numArray);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}