namespace LeetCodeProblems.Tests
{
    public class PalindromeNumberTest
    {
        PalindromeNumber _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new PalindromeNumber();
        }

        [Test]
        public void When_NegativeNumber_ReturnFalse()
        {
            // Arrange
            int number = -1;

            // Act
            var actual = _solution.IsPalindrome(number);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void When_PalindromeNumber_ReturnTrue()
        {
            // Arrange
            int number = 121;

            // Act
            var actual = _solution.IsPalindrome(number);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void When_NonPalindromeNumber_ReturnFalse()
        {
            // Arrange
            int number = 129;

            // Act
            var actual = _solution.IsPalindrome(number);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void When_NumberNotInRange_ReturnFalse()
        {
            // Arrange
            int number = int.MaxValue;
            number += 1;

            // Act
            var actual = _solution.IsPalindrome(number);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
