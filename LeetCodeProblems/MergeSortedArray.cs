using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    // Constraints: nums1.length == nums1.length + nums2.length
    // Do not create new Array
    // Follow up: Can you come up with an algorithm that runs in O(m + n) time?
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if(nums1 == null ||nums2 == null) throw new ArgumentNullException();
            while (m > 0 && n > 0) nums1[m + n - 1] = nums1[m - 1] > nums2[n - 1] ? nums1[--m] : nums2[--n];
            while (n > 0) nums1[--n] = nums2[n];
        }
    }
}
