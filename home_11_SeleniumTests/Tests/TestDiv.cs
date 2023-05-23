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
        [Retry(3)]
        public void TestCalcDivRetry()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Divide(random.NextInt64(), random.NextInt64(0, 1));

            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}
