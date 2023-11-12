using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Div_4Div2_Returned2()
        {
            var calc = new Calculator();
            int firstNumber = 4;
            int secondNumber = 2;
            int expectedNumber = 2;

            int result = calc.DivideNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_3Div0_ZeroDivException()
        {
            var calc = new Calculator();
            int firstNumber = 4;
            int secondNumber = 0;

            int result = calc.DivideNumbers(firstNumber, secondNumber);
        }


        [TestMethod]
        public void Sum_4Sum2_Returned6()
        {
            var calc = new Calculator();
            int firstNumber = 4;
            int secondNumber = 2;
            int expectedNumber = 6;

            int result = calc.SumNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void Mult_4Mult2_Returned8()
        {
            var calc = new Calculator();
            int firstNumber = 4;
            int secondNumber = 2;
            int expectedNumber = 8;

            int result = calc.MultipleNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void Sub_6Sub3_Returned3()
        {
            var calc = new Calculator();
            int firstNumber = 6;
            int secondNumber = 3;
            int expectedNumber = 3;

            int result = calc.SubstractNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, result);
        }
    }
}
