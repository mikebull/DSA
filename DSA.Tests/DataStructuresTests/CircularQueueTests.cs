using DSA.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DSA.Tests.DataStructuresTests
{
    [TestFixture]
    public class CircularQueueTests
    {
        private static List<String> elements = new List<String>()
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j"
        };

        [Test]
        public void CanAddString()
        {
            CircularQueue Queue = new CircularQueue(10);
            Queue.Add(elements[0]);
        }

        [Test]
        public void CanAddTwoStrings()
        {
            CircularQueue Queue = new CircularQueue(10);
            Queue.Add(elements[0]);
            Queue.Add(elements[1]);
        }

        [Test]
        public void CanPeekAfterOneAdd()
        {
            CircularQueue Queue = new CircularQueue(10);

            Queue.Add(elements[0]);
            string result = Queue.Peek();
            Assert.AreEqual(result, elements[0]);
        }
    }
}
