using System;

namespace DSA.DataStructures
{
    public class Stack
    {
        private string[] elements;
        private int top = -1;

        public Stack(int size)
        {
            if (size > 0) elements = new string[size];
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
            string temp = elements[top];
            elements[top--] = null;
            return temp;
        }
    }
}
