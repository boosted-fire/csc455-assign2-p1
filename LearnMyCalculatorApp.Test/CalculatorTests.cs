using LearnMyCalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using Microsoft.QualityTools.Testing.Fakes;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        //[DataRow(0, 0, 1)] // The test run with this row fails
        public void AddDataTests(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);

            // Same asserts as what is commented out above, but using Fluent Assertions
            //actual.Should().Be(2).And.NotBe(1);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(5, 1);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(5, 1);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            Assert.AreEqual(null, actual);
        }

        [TestMethod()]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        //[TestMethod]
        //public void DivideByZeroWithFakesShim()
        //{
        //    using (ShimsContext.Create())
        //    {
        //        // Define what the Divide shim should return
        //        ShimCalculator.AllInstances.DivideInt32Int32 = (x, y, z) => { return 1; };

        //        var calculator = new Calculator();

        //        // This really calls the DivideInt32Int32
        //        // defined above to always return 1
        //        // instead of actually calling Divide
        //        var actual = calculator.Divide(1, 0);
        //        Assert.AreEqual(1, actual); // This assertion will pass because the preceding Divide method is a shim that will return 1
        //    }
        //}
    }
}