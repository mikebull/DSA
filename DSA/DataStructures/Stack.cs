using System;

namespace DSA.DataStructures
{
    public class Stack
    {
        public string[] _items;
        private int top = -1;

        public Stack(int size)
        {
            if (size > 0) _items = new string[size];
            else throw new ArgumentException("Size must be > 0"); 
        }

        public bool IsEmpty()
        {
            if (top == -1) return true;
            else return false;
        }

        public void Push(string item)
        {
            top++;
            _items[top] = item;
        }

        public string Peek()
        {
            if (this.IsEmpty()) return null;
            else return _items[top];
        }

        public string Pop()
        {
            if (this.IsEmpty()) return null;
            string temp = _items[top];
            _items[top--] = null;
            return temp;
        }
    }
}
