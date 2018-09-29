using System;

namespace DSA.DataStructures
{
    public class PriorityQueue
    {
        private int[] _items;
        private int _maxSize;
        private int _count;

        public PriorityQueue(int size)
        {
            if (size > 0)
            {
                _items = new int[size];
                _maxSize = size;
                _count = 0;
            }
            else throw new ArgumentException("Queue size must be > 0");
        }

        public void Insert(int item)
        {
            if (_count == _maxSize) throw new ArgumentException("Queue is full");

            int i;
            if (_count == 0)
            {
                _items[0] = item;
                _count++;
            }
            else
            {
                for (i = _count - 1; i >= 0; i--)
                {
                    if (item > _items[i])
                    {
                        _items[i + 1] = _items[i];
                    }
                    else
                    {
                        break;
                    }
                }
                _items[i + 1] = item;
                _count++;
            }
        }

        public int Remove()
        {
            if (_count == 0) throw new ArgumentException("Queue is empty");

            int temp = _items[0];

            for (int i = 0; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_count - 1] = -1;
            _count--;

            return temp;
        }

        public int PeekFront()
        {
            return _items[0];
        }

        public int PeekBack()
        {
            return _items[_count - 1];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _maxSize;
        }
    }
}
