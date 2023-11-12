using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator
    {
        public int DivideNumbers(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }
        public int SumNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public int MultipleNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int SubstractNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
