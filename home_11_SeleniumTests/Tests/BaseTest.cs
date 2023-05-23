using MTS_SeleniumTests.Calculate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_11_SeleniumTests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public double operand1;
        protected double operand2;

        public Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();
        }

        //[SetUp]
        //public void Setup()
        //{
        //    Console.WriteLine("---- SetUp");
        //}

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("---- TearDown");
        }

        [OneTimeTearDown]
        public void OneTImeTearDown()
        {
            Console.WriteLine("- OneTimeTearDown");
        }

    }
}