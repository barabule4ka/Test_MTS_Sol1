using System;
using MTS_SeleniumTests.Calculate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_11_SeleniumTests.Tests
{
    internal class TestSub : BaseTest
    {
        [Test, Category("Subtract"), Description("Pozitive test")]
        [TestCase(15, 5.8, 9.2)]
        public void TestCalcSub(double operand1, double operand2, double result)
        {
            Assert.That(
            calculator.Subtract(operand1, operand2),
            Is.EqualTo(result));

        }

        [Test]
        [Category("Subtract")]
        [Description("Test using Values and Range")]
        public void TestCalcSubRange(
        [Values(20, 3)] double operand1,
        [Range(0, 10, 2)] double operand2)
        {
            var expected = 14;
            var actual = calculator.Subtract(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

            Console.WriteLine(actual);

        }
    }
}
