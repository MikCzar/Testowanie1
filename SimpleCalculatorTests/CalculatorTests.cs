using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            int result = calculator.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            int result = calculator.Add(-3, -4);
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
        {
            int result = calculator.Add(3, -4);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Subtract_PositiveNumbers_ReturnsCorrectDifference()
        {
            int result = calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsCorrectDifference()
        {
            int result = calculator.Subtract(-10, -4);
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsCorrectProduct()
        {
            int result = calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_NegativeNumbers_ReturnsCorrectProduct()
        {
            int result = calculator.Multiply(-3, -4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsCorrectQuotient()
        {
            int result = calculator.Divide(12, 4);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Division by zero is not allowed.")]
        public void Divide_DivisionByZero_ThrowsArgumentException()
        {
            calculator.Divide(12, 0);
        }

        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
        {
            int result = calculator.Divide(-12, -4);
            Assert.AreEqual(3, result);
        }
    }
}
