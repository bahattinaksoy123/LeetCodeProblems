using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /*
    Constraints:
    Only one valid answer exists.
    Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    */
    public class TwoSum
    {
        public int[] GetTwoSumIndexes(int[] nums, int target)
        {
            if (nums == null) throw new ArgumentNullException();
            if(nums.Length == 0) return new int[0];
            var solution = new int[2];
            for (int index = 0; index < nums.Count(); index++)
            {
                for (int index2 = index + 1; index2 < nums.Count(); index2++)
                {
                    if (nums[index] + nums[index2] == target)
                    {
                        solution[0] = index;
                        solution[1] = index2;
                        break;
                    }
                }
            }
            return solution;
        }
    }
}
