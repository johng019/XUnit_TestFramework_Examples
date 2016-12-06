using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestExample.cs
{
    public class CalculatorClass
    {
        //Set up of a testable class library

        public double quotient { get; set; }
        public double product { get; set; }
        public double diff { get; set; }
        public double sum { get; set; }
        private double num1 { get; set; }
        private double num2 { get; set; }

        public double Divide(double num1, double num2) => quotient = num1 / num2;
        public double Add(double num1, double num2) => sum = num1 + num2;
        public double Subtract(double num1, double num2) => diff = num1 - num2;
        public double Multiply(double num1, double num2) => product = num1 * num2;

    }
}
