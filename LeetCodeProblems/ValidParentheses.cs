using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ValidParentheses
    {
        // Constraints: s consists of parentheses only '()[]{}'.
        public bool IsValid(string s)
        {
            if (s == null) return true;
            // Adding brackets into dict, keys are closing brackets and values are opening brackets
            Dictionary<char, char> bracketDict = new Dictionary<char, char>();
            bracketDict.Add(')', '(');
            bracketDict.Add('}', '{');
            bracketDict.Add(']', '[');
            // Stack for applying LIFO (Last In First Out)        
            Stack<char> bracketStack = new Stack<char>();
            foreach (char ch in s)
            {
                if (bracketDict.ContainsValue(ch))
                { //if opening bracket
                    bracketStack.Push(ch);
                }
                else if (bracketDict.ContainsKey(ch)) // if closing bracket
                {
                    // last bracket in stack must equal to opening form of the current closing bracket
                    // Not: Pop() return and remove last element
                    if (bracketStack.Count == 0 || bracketStack.Pop() != bracketDict[ch]) return false;
                }
            }
            return bracketStack.Count == 0;
        }

        
    }
}


//test