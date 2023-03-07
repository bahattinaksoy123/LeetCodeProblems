namespace LeetCodeProblems.Tests
{
    public class LongestCommonPrefixTest
    {
        LongestCommonPrefix _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new LongestCommonPrefix();
        }

        [Test]
        public void When_Null_ThrowArgumentNullException()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => _solution.GetLongestCommonPrefix(null));
        }

        [Test]
        public void When_EmptyList_ReturnEmptyString()
        {
            // Arrange
            var strArray = new string[] { };

            // Act
            var actual = _solution.GetLongestCommonPrefix(strArray);

            // Assert
            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [Test]
        public void When_ThereIsCommonPrefix_ReturnCommonPrefix()
        {
            // Arrange
            var strArray = new string[] { "abcx", "abcdx", "abcdex" };

            // Act
            var actual = _solution.GetLongestCommonPrefix(strArray);

            // Assert
            Assert.That(actual, Is.EqualTo("abc"));
        }

        [Test]
        public void When_ThereIsNoCommonPrefix_ReturnEmptyString()
        {
            // Arrange
            var strArray = new string[] { "dog", "racecar", "car" };

            // Act
            var actual = _solution.GetLongestCommonPrefix(strArray);

            // Assert
            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [Test]
        public void When_ThereIsOneString_ReturnIt()
        {
            // Arrange
            var strArray = new string[] { "dog" };

            // Act
            var actual = _solution.GetLongestCommonPrefix(strArray);

            // Assert
            Assert.That(actual, Is.EqualTo(strArray[0]));
        }
    }
}
