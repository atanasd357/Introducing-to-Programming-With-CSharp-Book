using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1, test class

namespace HelloName.Tests
{
    [TestClass()]
    public class HelloNameTest
    {
        [TestMethod()]
        public void HelloNameTest1()
        {
            string actual = HelloName.PrintName("Nasko");
            string expected = "Hello, Nasko!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HelloNameTest2()
        {
            string actual = HelloName.PrintName("Maria");
            string expected = "Hello, Nasko!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HelloNameTest3()
        {
            string actual = HelloName.PrintName("Vesko");
            string expected = "This is not Nasko!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HelloNameTest4()
        {
            string actual = HelloName.PrintName("Maria");
            string expected = "Hello, Maria!";
            Assert.AreEqual(expected, actual);
        }
    }
}