using System;

namespace DSA.DataStructures
{
    public class Stack
    {
        public string[] _elements;
        private int top = -1;

        public Stack(int size)
        {
            if (size > 0) _elements = new string[size];
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
            _elements[top] = element;
        }

        public string Peek()
        {
            if (this.IsEmpty()) return null;
            else return _elements[top];
        }

        public string Pop()
        {
            if (this.IsEmpty()) return null;
            string temp = _elements[top];
            _elements[top--] = null;
            return temp;
        }
    }
}
