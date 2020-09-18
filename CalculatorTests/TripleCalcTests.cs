using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenGive3And4_Add_Returns7()
        {
            Assert.AreEqual(7, StaticCalculator.Add(3, 4));
        }

        [TestCase(3, 4, 7)]
        [TestCase(3, -4, -1)]
        public void WhenGivenTwoNumbers_Calculator_Add_ReturnsCorrectSum(int n1, int n2, int expected)
        {
            Assert.AreEqual(expected, StaticCalculator.Add(n1, n2));
        }

        [Test]
        public void WhenGive4And3_Subtract_Returns1()
        {
            Assert.AreEqual(1, StaticCalculator.Subtract(4, 3));
        }

        [Test]
        public void WhenGive8And4_Divide_Returns2()
        {
            Assert.AreEqual(2, StaticCalculator.Divide(8, 4));
        }

        [Test]
        public void WhenGive2And2_Multiply_Returns4()
        {
            Assert.AreEqual(4, StaticCalculator.Multiply(2, 2));
        }

        [Test]
        public void WhenGive5And2_Modulus_Returns1()
        {
            Assert.AreEqual(1, StaticCalculator.Modulus(5, 2));
        }
    }
}