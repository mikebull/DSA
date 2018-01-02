using DSA.DataStructures;

namespace DSA.ToyExamples
{
    //Uses LIFO stack to reverse a string
    public class MyStringReverser
    {
        public string Reverse(string input)
        {
            LIFOStack stack = new LIFOStack(input.Length);

            string reversed = "";
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                reversed = reversed + stack.Pop();
            }

            return reversed;
        }
    }
}
