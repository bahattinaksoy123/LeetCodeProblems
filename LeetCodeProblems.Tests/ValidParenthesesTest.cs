namespace LeetCodeProblems.Tests
{
    public class ValidParenthesesTest
    {
        ValidParentheses _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ValidParentheses();
        }

        [Test]
        public void When_Null_ReturnTrue()
        {
            // Act
            var actual = _solution.IsValid(null);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void When_Empty_ReturnTrue()
        {
            // Act
            var actual = _solution.IsValid(string.Empty);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        [TestCase("{ }}")]
        public void When_InsufficientOpeningBracket_ReturnFalse(string input)
        {
            // Act
            var actual = _solution.IsValid(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        [TestCase("{{ }")]
        public void When_InsufficientClosingBracket_ReturnFalse(string input)
        {
            // Act
            var actual = _solution.IsValid(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        [TestCase("( {) }")]
        public void When_WrongOrderedBracket_ReturnFalse(string input)
        {
            // Act
            var actual = _solution.IsValid(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        [TestCase("( { [ ] } )")]
        public void When_CorrectOrderedAndEnoughBracket_ReturnTrue(string input)
        {
            // Act
            var actual = _solution.IsValid(input);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
