using DSA.DataStructures;

namespace DSA.ToyExamples
{
    public class DelimiterMatcher
    {
        public bool IsBalanced(string input)
        {
            var Stack = new Stack<string>(input.Length);

            var closeDelimiters = "]})>";
            var openDelimiters = "[{(<";

            for (int i = 0; i < openDelimiters.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == openDelimiters[i])
                    {
                        if (input.Length == 1) return false;
                        Stack.Push(input[j].ToString());
                    }
                    else if (input[j] == closeDelimiters[i])
                    {
                        if (input.Length == 1) return false;
                        string lastDel = Stack.Peek();
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
