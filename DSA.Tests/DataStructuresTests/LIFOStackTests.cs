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
            LIFOStack Stack = new LIFOStack(10);
            Stack.Push("a");
        }

        [Test]
        public void PushPopReturnsCorrectValue()
        {
            LIFOStack Stack = new LIFOStack(10);
            string push = "a";
            Stack.Push(push);
            string result = Stack.Pop();

            Assert.AreEqual(push, result);
        }

        [Test]
        public void PushAPeekReturnsA()
        {
            LIFOStack Stack = new LIFOStack(10);
            string element = "a";

            Stack.Push(element);
            string result = Stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            LIFOStack Stack = new LIFOStack(10);

            Stack.Push("a");
            Stack.Pop();
            string result = Stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            LIFOStack Stack = new LIFOStack(10);

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
            LIFOStack Stack = new LIFOStack(10);

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
            LIFOStack Stack = new LIFOStack(10);

            string result = Stack.Pop();
        }

        [Test]
        public void IsEmptyReturnsFalseForEmptyStack()
        {
            LIFOStack Stack = new LIFOStack(10);
            bool response = Stack.IsEmpty();
            Assert.IsTrue(response);
        }

        [Test]
        public void IsEmptyReturnsTrueForNonEmptyStack()
        {
            LIFOStack Stack = new LIFOStack(10);
            Stack.Push("a");
            bool response = Stack.IsEmpty();
            Assert.IsFalse(response);
        }

        [Test]
        public void InstantiationOfStackWithLessOneThrowsException()
        {
            void a() => new LIFOStack(-1);

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }
    }
}