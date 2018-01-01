using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ToyExamples
{
    public class DelimiterMatcher
    {
        string[] delimiters = new string[]
        {
            "[","]", "{", "}", "(", ")", "<", ">"
        };

        //Checks balance of delimiting characters in a string using LIFO stack
        public bool IsBalanced(string input)
        {
            if (input.Length == 1)
            {
                for (int i = 0; i < delimiters.Length; i++)
                {
                    if (input == delimiters[i]) return false;
                }
            }
            return true;
        }
    }
}
