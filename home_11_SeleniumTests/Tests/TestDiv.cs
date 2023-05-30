using System;
using MTS_SeleniumTests.Calculate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_11_SeleniumTests.Tests
{
    internal class TestDiv : BaseTest
    {
        [Test, Category("Divide"), Description("Pozitive test")]
        [TestCase(10, -5, -2)]
        public void TestCalcDiv(double operand1, double operand2, double result)
        {
            Assert.That(
            calculator.Divide(operand1, operand2),
            Is.EqualTo(result));

        }

        [Test, Category("Divide"), Description("Strange test")]
        [Retry(5)]
        public void TestCalcDivRetry()
        {
            var random = new Random();
            var actual = calculator.Divide(random.Next(0, 4), random.Next(0, 5));
            Console.WriteLine(actual);
            Assert.That(actual, Is.GreaterThan(0));
        }


    }
}
