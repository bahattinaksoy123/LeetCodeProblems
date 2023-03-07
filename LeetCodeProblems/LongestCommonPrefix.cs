using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            if (strs == null) throw new ArgumentNullException(nameof(strs));
            if(strs.Length == 0) return string.Empty;
            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length)); //sorted by length
            string result = "";
            for (int index2 = 0; index2 < strs[0].Length; index2++) //loop for first str (the shortest)
            {
                for (int index = 1; index < strs.Length; index++) // loop for remaining strs
                {
                    if (strs[0][index2] != strs[index][index2])
                    {
                        return result;
                    }
                }
                result += strs[0][index2];
            }
            return result;
        }
    }
}
