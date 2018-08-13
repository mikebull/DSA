using System;

namespace DSA.DataStructures
{
    public class CircularQueue<T>
    {
        private readonly T[] _items;
        private readonly int _maxSize;
        private int _itemCount;
        private int _front;
        private int _back;

        public CircularQueue(int size)
        {
            if (size > 0)
            {
                _items = new T[size];
                _maxSize = size;
                _itemCount = 0;
                _front = 0;
                _back = -1;
            }
            else
            {
                throw new ArgumentException("Size must be > 0");
            }
        }

        public void Enqueue(T item)
        {
            if (_itemCount == _maxSize)
            {
                throw new ArgumentException("Queue is full");
            }
            else if (_back == _maxSize - 1)
            {
                _back = -1;
            }

            _items[_back + 1] = item;
            _back++;
            _itemCount++;
        }

        public T Dequeue()
        {
            if (_itemCount == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            T temp = _items[_front];
            _items[_front] = default(T);

            if (_front == _maxSize - 1)
            {
                _front = 0;
            }
            else
            {
                _front++;
            }

            _itemCount--;
            return temp;
        }

        public T Peek()
        {
            return _items[_front];
        }

        public bool IsFull()
        {
            if (_itemCount == _maxSize)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (_itemCount == 0)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            return _itemCount;
        }
    }
}
