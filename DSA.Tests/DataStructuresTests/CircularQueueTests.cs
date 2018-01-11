using DSA.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DSA.Tests.DataStructuresTests
{
    [TestFixture]
    public class CircularQueueTests
    {
        private static List<String> _elements = new List<String>()
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"
        };

        [Test]
        public void CanEnqueueOneElement()
        {
            CircularQueue Queue = new CircularQueue(10);
            Queue.Enqueue(_elements[0]);
        }

        [Test]
        public void CanEnqueueTwoElements()
        {
            CircularQueue Queue = new CircularQueue(10);
            Queue.Enqueue(_elements[0]);
            Queue.Enqueue(_elements[1]);
        }

        [Test]
        public void Enqueue_PeekReturnsFirstEnqueue()
        {
            CircularQueue Queue = new CircularQueue(10);

            Queue.Enqueue(_elements[0]);

            string result = Queue.Peek();

            Assert.AreEqual(_elements[0], result);
        }

        [Test]
        public void Enqueue_Enqueue_Peek_ReturnsFirstEnqueue()
        {
            CircularQueue Queue = new CircularQueue(10);
            string firstElement = _elements[0];
            string secondElement = _elements[1];

            Queue.Enqueue(firstElement);
            Queue.Enqueue(secondElement);

            string result = Queue.Peek();

            Assert.AreEqual(firstElement, result);
        }

        [Test]
        public void AddingMoreThanMaxSizeThrowsException()
        {
            CircularQueue Queue = new CircularQueue(10);

            foreach (var element in _elements) Queue.Enqueue(element);

            void a() => Queue.Enqueue("OneTooMany");

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }

        [Test]
        public void Enqueue_Dequeue_ReturnsFirstEnqueue()
        {
            CircularQueue Queue = new CircularQueue(10);
            string firstElement = _elements[0];

            Queue.Enqueue(firstElement);
            string result = Queue.Dequeue();

            Assert.AreEqual(firstElement, result);
        }


        [Test]
        public void Enqueue_Enqueue_Size_Returns2()
        {
            CircularQueue Queue = new CircularQueue(10);

            for (int i = 0; i < 2; i++)
            {
                Queue.Enqueue(_elements[i]);
            }

            int result = Queue.Size();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void WrapAroundWorks()
        {
            CircularQueue Queue = new CircularQueue(10);

            foreach (var element in _elements) Queue.Enqueue(element);

            Queue.Dequeue();
            Queue.Enqueue("a");
            string result = Queue.Peek();

            Assert.AreEqual("2", result);
        }

        [Test]
        public void VariousQueue_Enqueue()
        {
            CircularQueue Queue = new CircularQueue(4);

            Queue.Enqueue("a");
            Queue.Enqueue("b");
            Queue.Enqueue("c");
            Queue.Enqueue("d");
            Queue.Dequeue(); //removes a
            Queue.Dequeue(); //removes b
            Queue.Dequeue(); //removes c
            Queue.Enqueue("e");
            Queue.Enqueue("f");
            Queue.Enqueue("g");
            Queue.Dequeue(); //removes d
            Queue.Enqueue("h");
            Queue.Dequeue(); //removes e
            Queue.Dequeue(); //removed f
            Queue.Dequeue(); //removes g
            string result = Queue.Peek();
            Assert.AreEqual("h", result);
        }

        [Test]
        public void IsFullReturnsTrueOnFullQueue()
        {
            CircularQueue Queue = new CircularQueue(1);

            Queue.Enqueue("a");
            Assert.IsTrue(Queue.IsFull());
        }

        [Test]
        public void IsFullReturnsFalseOnPartialQueue()
        {
            CircularQueue Queue = new CircularQueue(2);

            Queue.Enqueue("a");
            Assert.IsFalse(Queue.IsFull());
        }

        [Test]
        public void IsEmptylReturnsFalseOnPartialQueue()
        {
            CircularQueue Queue = new CircularQueue(1);

            Queue.Enqueue("a");
            Assert.IsFalse(Queue.IsEmpty());
        }

        [Test]
        public void IsEmptyReturnsTrueOnEmptyQueue()
        {
            CircularQueue Queue = new CircularQueue(2);

            Assert.IsTrue(Queue.IsEmpty());
        }
    }
}
