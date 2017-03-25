using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorUnitTests
{
    [TestClass]
    public class UnitTestsForCalculator
    {
        ICalculator _calc;

        [TestInitialize]
        public void TestSetUp()
        {
            _calc = new Calculator();
        }
        [TestMethod]
        public void TestAdditionForGoodResult()
        {
            int res = _calc.Addition(2, 6);
            Assert.AreEqual(8, res);
        }
        [TestMethod]
        public void TestAdditionForBadResult()
        {
            int res = _calc.Addition(2, 6);
            Assert.AreNotEqual(6, res);
        }
        [TestMethod]
        public void TestSubstractionForGoodResult()
        {
            int res = _calc.Substraction(2, 6);
            Assert.AreEqual(-4, res);
        }
        [TestMethod]
        public void TestSubstractionForBadResult()
        {
            int res = _calc.Substraction(2, 2);
            Assert.AreNotEqual(6, res);
        }
        [TestMethod]
        public void TestMultiplicationForGoodResult()
        {
            int res = _calc.Multiplication(2, 6);
            Assert.AreEqual(12, res);
        }
        [TestMethod]
        public void TestMultiplicationForBadResult()
        {
            int res = _calc.Multiplication(2, 6);
            Assert.AreNotEqual(8, res);
        }
        [TestMethod]
        public void TestDivisionForGoodResult()
        {
            int res = _calc.Division(6,2);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestDivisionForBadResult()
        {
            int res = _calc.Division(2, 6);
            Assert.AreNotEqual(8, res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivisionForBadParam()
        {
            int res = _calc.Division(2, 0);
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            _calc = null;
        }
    }
}
