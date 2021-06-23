using DecimalChecker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DecimalChecker.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Valid_SetNull_ArgumentNullException()
        {
            DecimalNumber number = new DecimalNumber();
            number.Input = null;

        }
    }
}
