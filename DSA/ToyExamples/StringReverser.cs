using DSA.DataStructures;

namespace DSA.ToyExamples
{
    //Uses LIFO stack to reverse a string
    public class MyStringReverser
    {
        public string Reverse(string input)
        {
            LIFOStack Stack = new LIFOStack(input.Length);

            string reversed = "";
            for (int i = 0; i < input.Length; i++)
            {
                Stack.Push(input[i].ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                reversed = reversed + Stack.Pop();
            }

            return reversed;
        }
    }
}
