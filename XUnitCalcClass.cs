using System.Collections.Generic;
using Xunit;

namespace XUnitTestExample.cs
{
    public class XUnitCalcClass
    {
        [Fact]
        public void VerifyAddMethodReturnsSumofTwoNumbers()
        {
            CalculatorClass obj1 = new CalculatorClass();
            double result = obj1.Add(4, 5);
            Assert.Equal(9, result);
        }
        [Fact]
        public void VerifySubtractMethodReturnsDiffrenceOfTwoNumbers()
        {
            CalculatorClass obj2 = new CalculatorClass();
            double result = obj2.Subtract(10,5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void VerrifyMultiplyMethodReturnsProductOfTwoNumbers()
        {
            CalculatorClass obj3 = new CalculatorClass();
            double result = obj3.Multiply(3,9);
            Assert.Equal(27,result);
        }

        //Multiple Parameters Examples
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(8, 2, 4)]
        [InlineData(72, 9, 8)]
        public void VerifyDivideMethodUsingMultipleParameters(double num1, double num2, double expected)
        {
            CalculatorClass obj4 = new CalculatorClass();
            double result = obj4.Divide(num1, num2);
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData(4, -5, -1)]
        [InlineData(-8, 2, -6)]
        [InlineData(-2, -9, -11)]
        public void VerifyUsingNegativeNumbersWithMultipleParametersReturnsCorrectValue(double num1, double num2,double expected)
        {
            CalculatorClass obj5 = new CalculatorClass();
            double result = obj5.Add(num1, num2);
            Assert.Equal(expected,result);
        }

        //External method for geting multiple parameters
        [Theory]
        [MemberData("SupplyingExternalParametersMethod")]
        public void VerifyMultipleParametersFromExternalMethodProducesCorrectSum(double num1, double num2, double expected)
        {
            CalculatorClass obj6 = new CalculatorClass();
            double result = obj6.Add(num1, num2);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object> SupplyingExternalParametersMethod()
        {
            for (int i = 1; i < 5; i++)
            {
                yield return new object[] { i,i+1,i+i+1 };
            }
            
        }
    }
}
