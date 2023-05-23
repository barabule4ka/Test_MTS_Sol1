using System;
using MTS_SeleniumTests.Calculate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_11_SeleniumTests.Tests
{
    internal class TestMult : BaseTest
    {
        [Test, Category("Multiplication"), Description("Pozitive test")]
        [TestCase(10, -5.5, -55)]
        public void TestCalcMultiply(double operand1, double operand2, double result)
        {
            Assert.That(
            calculator.Multiply(operand1, operand2),
            Is.EqualTo(result));

            Console.WriteLine($"{operand1} * {operand2} = {result}");
        }
    }
}
