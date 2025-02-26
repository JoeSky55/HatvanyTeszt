using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HatvanyKonzolos;

namespace HatvanyTeszt
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(2,3);
            TestResult.Equals(8,result);
        }

        [TestMethod]
        public void TestZeroExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(5, 0);
            TestResult.Equals(1, result);
        }

        [TestMethod]
        public void TestNegativeExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(2, (-2));
            TestResult.Equals(0.25, result);
        }

        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(0, 5);
            TestResult.Equals(0, result);
        }

        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(0, 0);
            TestResult.Equals(1, result);
        }

        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower(1, 100);
            TestResult.Equals(1, result);
        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower((-3), 4);
            TestResult.Equals(81, result);
        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower((-2), 3);
            TestResult.Equals((-8), result);
        }
        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {
            var hatvany = new PowerCalculator();
            double result = hatvany.CalculatePower((-2), 2);
            TestResult.Equals(0.25, result);
        }
    }
}
