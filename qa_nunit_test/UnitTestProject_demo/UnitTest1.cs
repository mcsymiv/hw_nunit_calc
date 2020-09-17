using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using qa_nunit_test;
using NUnit.Framework;
using qa_auto_unit_test;

namespace UnitTestProject_demo
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void Init()
        {
            Console.WriteLine("Open calculator");
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("Clear inputs");
        }

        [TestCase(21, 2, 23)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, -4, -8)]
        [TestCase(0, -4, -4)]
        [TestCase(3, -4, -1)]
        public void AddTwoNumbersCheck(double a, double b, double expResult)
        {
            double actResult = new Calc().Addition(a, b);
            Assert.AreEqual(expResult, actResult);
        }

        [TestCase(21, 2, 19)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, -4, 0)]
        [TestCase(0, -4, 4)]
        [TestCase(3, -4, 7)]
        public void SubtractTwoNumbersCheck(double a, double b, double expResult)
        {
            double actResult = new Calc().Subtract(a, b);
            Assert.AreEqual(expResult, actResult);
        }

        [TestCase(3, 2, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, 0, 0)]
        [TestCase(0, -4, 0)]
        [TestCase(3, -4, -12)]
        public void MultiplyTwoNumbersCheck(double a, double b, double expResult)
        {
            double actResult = new Calc().Multiply(a, b);
            Assert.AreEqual(expResult, actResult);
        }

        [TestCase(1, 3, 0.33333333333333331d)]
        [TestCase(0, 0, double.NaN)]
        [TestCase(12, 3, 4)]
        [TestCase(4, 0, double.PositiveInfinity)]
        [TestCase(1, 2, 0.5)]
        public void DivideTwoNumbersCheck(double a, double b, double expResult)
        {
            double actResult = new Calc().Divide(a, b);
            Assert.AreEqual(expResult, actResult);
        }
    }
}
