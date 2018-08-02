using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractionTests
{
    [TestClass]
    public class FunWithMathsTests
    {
        [TestMethod]
        public void TestMultiplyNumbers()
        {
            // arrange
            var oddNums = new Abstraction.OddNumberProvider();
            var evenNums = new Abstraction.EvenNumberProvider();
            var expectedResultEven = 3840;
            var expectedResultOdd = 945;
            // act
            var mathsClass = new Abstraction.FunWithMaths();
            var resultNumEven = mathsClass.MultiplyNumbers(evenNums);
            var resultNumOdd = mathsClass.MultiplyNumbers(oddNums);
            // assert
            Assert.AreEqual(expectedResultEven, resultNumEven);
            Assert.AreEqual(expectedResultOdd, resultNumOdd);
        }
        [TestMethod]
        public void TestMultiplyNumbersWithMockProvider()
        {
            // arrange
            var nums = new Abstraction.MockNumberProvider();
            var expectedResult = 1;
            // act
            var mathsClass = new Abstraction.FunWithMaths();
            var resultNums = mathsClass.MultiplyNumbers(nums);
            // assert
            Assert.AreEqual(expectedResult, resultNums);
        }
    }
}
