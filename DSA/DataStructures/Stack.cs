using System;

namespace DSA.DataStructures
{
    public class Stack
    {
        public string[] Elements{ get; set; }
        private int top = -1;

        public Stack(int size)
        {
            if (size > 0) Elements = new string[size];
            else throw new ArgumentException("Size must be > 0"); 
        }

        public bool IsEmpty()
        {
            if (top == -1) return true;
            else return false;
        }

        public void Push(string element)
        {
            top++;
            Elements[top] = element;
        }

        public string Peek()
        {
            if (this.IsEmpty()) return null;
            else return Elements[top];
        }

        public string Pop()
        {
            if (this.IsEmpty()) return null;
            string temp = Elements[top];
            Elements[top--] = null;
            return temp;
        }
    }
}
