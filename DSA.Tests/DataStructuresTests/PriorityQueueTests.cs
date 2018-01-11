using DSA.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.DataStructuresTests
{
    [TestFixture]
    public class PriorityQueueTests
    {
        [Test]
        public void CanInstantiateNSizedQueue()
        {
            PriorityQueue queue = new PriorityQueue(1);
        }

        [Test]
        public void CanInsertSingleItem()
        {
            PriorityQueue queue = new PriorityQueue(1);

            queue.Insert(1);
        }

        [Test]
        public void CanPeekFrontSingleItem()
        {
            PriorityQueue queue = new PriorityQueue(1);

            queue.Insert(1);
            int item = queue.PeekFront();
        }

        [Test]
        public void CanPeekFrontfThreeItems()
        {
            PriorityQueue queue = new PriorityQueue(3);

            queue.Insert(1);
            queue.Insert(3);
            queue.Insert(2);
            int result = queue.PeekFront();

            Assert.AreEqual(3, result);
        }

        [Test]
        public void CanPeekBackOfThreeItems()
        {
            PriorityQueue queue = new PriorityQueue(3);

            queue.Insert(3);
            queue.Insert(1);
            queue.Insert(2);
            int result = queue.PeekBack();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void CanRemoveItem()
        {
            PriorityQueue queue = new PriorityQueue(1);

            queue.Insert(3);
            int result = queue.Remove();

            Assert.AreEqual(3, result);
        }

        [Test]
        public void RemoveMultipleItemsPreservesOrder()
        {
            PriorityQueue queue = new PriorityQueue(4);

            List<int> results = new List<int>();
            List<int> expected = new List<int>() { 4, 3, 2, 1 };

            queue.Insert(1);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(4);

            results.Add(queue.Remove());
            results.Add(queue.Remove());
            results.Add(queue.Remove());
            results.Add(queue.Remove());

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void IsEmptyReturnsTrueForEmptyQ()
        {
            PriorityQueue queue = new PriorityQueue(1);
            bool result = queue.IsEmpty();
            Assert.IsTrue(result);
        }

        [Test]
        public void IsEmptyReturnsFalseForNonEmptyQ()
        {
            PriorityQueue queue = new PriorityQueue(1);
            queue.Insert(1);
            bool result = queue.IsEmpty();
            Assert.IsFalse(result);
        }

        [Test]
        public void IsFullReturnsTrueForFullQ()
        {
            PriorityQueue queue = new PriorityQueue(1);
            queue.Insert(1);
            bool result = queue.IsFull();
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFullReturnsFalseForNonFullQ()
        {
            PriorityQueue queue = new PriorityQueue(2);
            queue.Insert(1);
            bool result = queue.IsFull();
            Assert.IsFalse(result);
        }

        [Test]
        public void ThrowsExceptionWhenInsertOnFullQ()
        {
            PriorityQueue queue = new PriorityQueue(1);

            queue.Insert(1);
            void a() => queue.Insert(2);

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }
        [Test]
        public void ThrowsExceptionWhenRemoveOnEmptyQ()
        {
            PriorityQueue queue = new PriorityQueue(1);

            void a() => queue.Remove();

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }
    }
}
