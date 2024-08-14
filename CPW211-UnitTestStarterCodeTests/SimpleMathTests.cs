using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10, 15)]
        [DataRow(0, 100, 100)]
        [DataRow(-1, -10, -11)]
        [DataRow(0, 0, 0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Add(num1, num2);
        
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10, 50)]
        [DataRow(0, 100, 0)]
        [DataRow(-1, -10, 10)]
        [DataRow(0, 0, 0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Multiply(num1, num2);
        
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange
            double numerator = 10;
            double denominator = 0;
        
            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => SimpleMath.Divide(numerator, denominator));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(100, 10, 10)]
        [DataRow(-10, -2, 5)]
        [DataRow(10, -2, -5)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Divide(num1, num2);
        
            // Assert
            Assert.AreEqual(expected, result);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(100, 50, 50)]
        [DataRow(-10, -5, -5)]
        [DataRow(10, -5, 15)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Subtract(num1, num2);
        
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
