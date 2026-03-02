using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorApp;

namespace TestProject
{
    internal class CalculatorTest
    {
        
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            //Arrange
            int a = 5, b = 3;

            //Act
            int result=calc.Add(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(8));

        }
        [Test]
        public void Subtract_TwoNumbers_ReturnDifference()
        {
            //Arrange
            int a = 5, b = 3;

            //Act
            int result = calc.Subtract(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Multiply_TwoNumbers_ReturnProduct()
        {
            //Arrange
            int a = 5, b = 3;

            //Act
            int result = calc.Multiply(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(15));

        }
        [Test]
        public void Divide_ByZero_ThrowException()
        {
            //Assert
            int a = 10, b = 0;
            //Act & Assert
            Assert.Throws<DivideByZeroException>(()=>calc.Divide(a, b));
        }
        [Test]
        public void Divide_ValidNumbers_ReturnQuotient()
        {
            //Arrange
            int a = 10, b = 2;

            //Act
            double result = calc.Divide(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(5));

        }



    }
}
