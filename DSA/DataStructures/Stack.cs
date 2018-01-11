using System;

namespace DSA.DataStructures
{
    public class Stack
    {
        public string[] _items;
        private int _top = -1;

        public Stack(int size)
        {
            if (size > 0) _items = new string[size];
            else throw new ArgumentException("Size must be > 0"); 
        }

        public bool IsEmpty()
        {
            if (_top == -1) return true;
            else return false;
        }

        public void Push(string item)
        {
            _top++;
            _items[_top] = item;
        }

        public string Peek()
        {
            if (this.IsEmpty()) return null;
            else return _items[_top];
        }

        public string Pop()
        {
            if (this.IsEmpty()) return null;
            string temp = _items[_top];
            _items[_top--] = null;
            return temp;
        }
    }
}
