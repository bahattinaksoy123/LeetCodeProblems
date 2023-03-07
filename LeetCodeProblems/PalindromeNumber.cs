using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    //Follow up: Could you solve it without converting the integer to a string?
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int input = x;
            int reversed = 0;
            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }
            return input == reversed;
        }
    }
}
