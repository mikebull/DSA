﻿using DSA.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ToyExamples
{
    public class DelimiterMatcher
    {
        //Checks balance of delimiting characters in a string using LIFO stack
        public bool IsBalanced(string input)
        {
            LIFOStack stack = new LIFOStack(input.Length);

            string closeDelimiters = "]})>";
            string openDelimiters = "[{(<";

            for (int i = 0; i < openDelimiters.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == openDelimiters[i])
                    {
                        if (input.Length == 1) return false;
                        stack.Push(input[j].ToString());
                    }
                    else if (input[j] == closeDelimiters[i])
                    {
                        if (input.Length == 1) return false;
                        string lastDel = stack.Peek();
                        for (int k = 0; k < openDelimiters.Length; k++)
                        {
                            if (openDelimiters[k].ToString() == lastDel && k != j) return false; 
                        }
                    }
                }
            }
            return true;
        }
    }
}