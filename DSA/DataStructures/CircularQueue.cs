using System;

namespace DSA.DataStructures
{
    public class CircularQueue
    {
        private string[] Elements { get; set; }
        private int MaxSize { get; set; }
        private int ElementCount { get; set; }
        private int Front { get; set; }
        private int Back { get; set; }

        public CircularQueue(int size)
        {
            if (size > 0)
            {
                Elements = new String[size];
                MaxSize = size;
                ElementCount = 0;
                Front = 0;
                Back = -1;
            }
            else throw new ArgumentException("Size must be > 0");
        }

        public void Enqueue(string element)
        {
            if (this.Size() == MaxSize)
            {
                throw new ArgumentException("Queue is full");
            }
            else if (Back == MaxSize - 1)
            {
                Back = -1;
            }

            Elements[Back + 1] = element;
            Back++;
            ElementCount++;
        }

        public string Dequeue()
        {
            if (this.Size() == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            string temp = Elements[Front];
            Elements[Front] = null;

            if (Front == MaxSize - 1)
            {
                Front = 0;
            }
            else
            {
                Front++;
            }

            ElementCount--;
            return temp;
        }

        public string Peek()
        {
            return Elements[Front];
        }

        public bool IsFull()
        {
            if (ElementCount == MaxSize)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (ElementCount == 0)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            return ElementCount;
        }
    }
}
