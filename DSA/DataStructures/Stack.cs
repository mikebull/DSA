namespace DSA.DataStructures
{
    public class MyLIFOStack
    {
        private string[] elements;
        private int top = -1;

        public MyLIFOStack(int size)
        {
            elements = new string[size];
        }

        public bool IsEmpty()
        {
            if (top == -1) return true;
            else return false;
        }

        public void Push(string element)
        {
            top++;
            elements[top] = element;
        }

        public string Peek()
        {
            if (this.IsEmpty()) return null;
            else return elements[top];
        }

        public string Pop()
        {
            if (this.IsEmpty()) return null;
            return elements[top--] = null;
        }
    }
}
