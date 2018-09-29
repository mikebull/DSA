using DSA.DataStructures;

namespace DSA.ToyExamples
{
    //Uses LIFO stack to reverse a string
    public class MyStringReverser
    {
        public string Reverse(string input)
        {
            var Stack = new Stack<string>(input.Length);

            var reversed = "";
            for (var i = 0; i < input.Length; i++)
            {
                Stack.Push(input[i].ToString());
            }

            for (var i = 0; i < input.Length; i++)
            {
                reversed += Stack.Pop();
            }

            return reversed;
        }
    }
}
