namespace LeetCodeProblems.Tests
{
    public class TwoSumTest
    {
        TwoSum _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new TwoSum();
        }

        [Test]
        public void When_ArrayNull_ThrowArgumentNullException()
        {
            // Arrange
            int stubTarget = 0;

            // Assert
            Assert.Throws<ArgumentNullException>(() => _solution.GetTwoSumIndexes(null, stubTarget));
        }


        [Test]
        public void When_ArrayEmpty_ReturnEmptyArray()
        {
            // Arrange
            int[] emptyArray = new int[] { };
            int stubTarget = 0;

            // Act
            var actual = _solution.GetTwoSumIndexes(emptyArray, stubTarget);

            // Assert
            Assert.That(actual, Is.EquivalentTo(emptyArray));
        }

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[2] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[2] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[2] { 0, 1 })]
        public void When_ThereIsValues_ReturnIndexes(int[] intArray, int target, int[] result)
        {
            // Act
            var actual = _solution.GetTwoSumIndexes(intArray, target);

            // Assert
            Assert.That(actual, Is.EquivalentTo(result));
        }
    }
}
