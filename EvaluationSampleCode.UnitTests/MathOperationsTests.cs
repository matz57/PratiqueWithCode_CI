namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(10, 5, 15)]
        [DataRow(999, 1, 1000)]
        [DataRow(1, 500, 501)]
        public void Add_WithTwoNumbers_ReturnAddition(int numberOne, int numberTwo, int expectedResult)
        {
            var actualResult = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(50, 2, 25)]
        [DataRow(9, 3, 3)]
        public void Divide_WithTwoNumbers_ReturnDivision(int numberOne, int numberTwo, int expectedResult)
        {
            var actualResult = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divide_WithSecondZero_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(100, 0));
        }

        [TestMethod]
        public void GetOddNumbers_WithPositiveNumber_ReturnOddNumbers()
        {
            var actualResult = _mathOperations.GetOddNumbers(10);

            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 7, 9 }, actualResult.ToArray());
        }
    }
}