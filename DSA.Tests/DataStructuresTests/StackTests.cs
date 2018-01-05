using DSA.DataStructures;
using NUnit.Framework;
using System;

namespace DSA.Tests
{
    [TestFixture]
    public class LIFOStackTests
    {
        [Test]
        public void PushSucceeds()
        {
            Stack Stack = new Stack(10);
            Stack.Push("a");
        }

        [Test]
        public void PushPopReturnsCorrectValue()
        {
            Stack Stack = new Stack(10);
            string push = "a";
            Stack.Push(push);
            string result = Stack.Pop();

            Assert.AreEqual(push, result);
        }

        [Test]
        public void PushAPeekReturnsA()
        {
            Stack Stack = new Stack(10);
            string element = "a";

            Stack.Push(element);
            string result = Stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            Stack Stack = new Stack(10);

            Stack.Push("a");
            Stack.Pop();
            string result = Stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            Stack Stack = new Stack(10);

            string firstPush = "a";
            string secondPush = "b";

            Stack.Push(firstPush);
            Stack.Push(secondPush);
            Stack.Pop();
            string result = Stack.Peek();

            Assert.AreEqual(firstPush, result);
        }

        [Test]
        public void PushPushPushPushPopPopPeekkReturnsSecondPush()
        {
            Stack Stack = new Stack(10);

            string firstPush = "a";
            string secondPush = "b";
            string thirdPush = "c";
            string fourthPush = "d";

            Stack.Push(firstPush);
            Stack.Push(secondPush);
            Stack.Push(thirdPush);
            Stack.Push(fourthPush);
            Stack.Pop();
            Stack.Pop();
            string result = Stack.Peek();
            Assert.AreEqual(result, secondPush);
        }

        [Test]
        public void PopEmptyStackReturnsNull()
        {
            Stack Stack = new Stack(10);

            string result = Stack.Pop();
        }

        [Test]
        public void IsEmptyReturnsFalseForEmptyStack()
        {
            Stack Stack = new Stack(10);
            bool response = Stack.IsEmpty();
            Assert.IsTrue(response);
        }

        [Test]
        public void IsEmptyReturnsTrueForNonEmptyStack()
        {
            Stack Stack = new Stack(10);
            Stack.Push("a");
            bool response = Stack.IsEmpty();
            Assert.IsFalse(response);
        }

        [Test]
        public void InstantiationOfStackWithLessOneThrowsException()
        {
            void a() => new Stack(-1);

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }
    }
}