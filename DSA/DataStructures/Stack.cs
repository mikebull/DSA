using System;

namespace DSA.DataStructures
{
    public class Stack<T>
    {
        public T[] _items;
        private int _top = -1;

        public Stack(int size)
        {
            if (size > 0) _items = new T[size];
            else throw new ArgumentException("Size must be > 0"); 
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public void Push(T item)
        {
            _top++;
            _items[_top] = item;
        }

        public T Peek()
        {
            if (_top == -1) return default(T);
            else return _items[_top];
        }
   
        public T Pop()
        {
            if (_top == -1) return default(T);
            T temp = _items[_top];
            _items[_top--] = default(T);
            return temp;
        }
    }
}
