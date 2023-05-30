using System;
using MTS_SeleniumTests.Calculate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_11_SeleniumTests.Tests
{
    internal class TestAdd : BaseTest
    {
        [Test, Category("Addition"), Description("Pozitive test")]
        [TestCase(10, 5, 15)]
        public void TestCalcSum(double operand1, double operand2, double result)
        {
            Assert.That(
            calculator.Add(operand1, operand2),
            Is.EqualTo(result));

        }

        [Test, Category("Addition"), Description("Test using Values and Random")]
        public void TestCalcSumRandom(
        [Values(1, 2)] double operand1,
            [Random(0, 10, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

            Console.WriteLine(actual);
        }

    }
}
