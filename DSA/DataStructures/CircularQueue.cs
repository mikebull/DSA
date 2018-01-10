using System;

namespace DSA.DataStructures
{
    public class CircularQueue
    {
        private string[] _elements;
        private int _maxSize;
        private int _itemCount;
        private int _front;
        private int _back;

        public CircularQueue(int size)
        {
            if (size > 0)
            {
                _elements = new String[size];
                _maxSize = size;
                _itemCount = 0;
                _front = 0;
                _back = -1;
            }
            else throw new ArgumentException("Size must be > 0");
        }

        public void Enqueue(string element)
        {
            if (this.Size() == _maxSize)
            {
                throw new ArgumentException("Queue is full");
            }
            else if (_back == _maxSize - 1)
            {
                _back = -1;
            }

            _elements[_back + 1] = element;
            _back++;
            _itemCount++;
        }

        public string Dequeue()
        {
            if (this.Size() == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            string temp = _elements[_front];
            _elements[_front] = null;

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

        public string Peek()
        {
            return _elements[_front];
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
