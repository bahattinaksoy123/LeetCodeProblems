namespace LeetCodeProblems.Tests
{
    public class MergeSortedArraytest
    {
        MergeSortedArray _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MergeSortedArray();
        }

        [Test]
        public void When_AnyOfArrayNull_ThrowArgumentNullException()
        {
            // Arrange
            int[] nums1 = null;
            int[] nums2 = null;
            int length1 = 0, length2 = 0;

            // Assert
            Assert.Throws<ArgumentNullException>(()=> _solution.Merge(nums1, length1, nums2, length2));
        }

        [Test]
        public void When_SecondArrayEmpty_ResultFirstArray()
        {
            // Arrange
            int[] nums1 = new int[] { 1 };
            int[] nums2 = new int[] { };
            int length1 = nums1.Length, length2 = 0;

            int[] tempNums1 = new int[length1];
            nums1.CopyTo(tempNums1, 0);

            // Act
            _solution.Merge(nums1, length1, nums2, length2);

            // Assert
            Assert.That(nums1, Is.EquivalentTo(tempNums1));
        }


        [Test]
        public void When_ArraysAreEmpty_ResultEmptyArray()
        {
            // Arrange
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { };
            int length1 = 0, length2 = 0;

            int[] emptyArray = new int[] { };

            // Act
            _solution.Merge(nums1, length1, nums2, length2);

            // Assert
            Assert.That(nums1, Is.EquivalentTo(emptyArray));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new int[] { 0, 0 }, 1, new int[] { 1 }, 1, new int[] { 0, 1 })]
        public void When_ArraysHaveValues_ResultMergedOfThem(int[] nums1, int length1, int[] nums2, int length2, int[] result)
        {
            // Act
            _solution.Merge(nums1, length1, nums2, length2);

            // Assert
            Assert.That(nums1, Is.EquivalentTo(result));
        }
    }
}
