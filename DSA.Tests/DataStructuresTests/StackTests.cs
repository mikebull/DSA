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
            var Stack = new Stack<string>(10);
            Stack.Push("a");
        }

        [Test]
        public void PushPopReturnsCorrectValue()
        {
            var Stack = new Stack<string>(10);
            var push = "a";
            Stack.Push(push);
            var result = Stack.Pop();

            Assert.AreEqual(push, result);
        }

        [Test]
        public void PushAPeekReturnsA()
        {
            var Stack = new Stack<string>(10);
            var element = "a";

            Stack.Push(element);
            var result = Stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            var Stack = new Stack<string>(10);

            Stack.Push("a");
            Stack.Pop();
            var result = Stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            var Stack = new Stack<string>(10);

            var firstPush = "a";
            var secondPush = "b";

            Stack.Push(firstPush);
            Stack.Push(secondPush);
            Stack.Pop();
            var result = Stack.Peek();

            Assert.AreEqual(firstPush, result);
        }

        [Test]
        public void PushPushPushPushPopPopPeekkReturnsSecondPush()
        {
            var Stack = new Stack<string>(10);

            var firstPush = "a";
            var secondPush = "b";
            var thirdPush = "c";
            var fourthPush = "d";

            Stack.Push(firstPush);
            Stack.Push(secondPush);
            Stack.Push(thirdPush);
            Stack.Push(fourthPush);
            Stack.Pop();
            Stack.Pop();
            var result = Stack.Peek();
            Assert.AreEqual(result, secondPush);
        }

        [Test]
        public void PopEmptyStackReturnsNull()
        {
            var Stack = new Stack<string>(10);

            var result = Stack.Pop();
        }

        [Test]
        public void IsEmptyReturnsFalseForEmptyStack()
        {
            var Stack = new Stack<string>(10);
            var response = Stack.IsEmpty();
            Assert.IsTrue(response);
        }

        [Test]
        public void IsEmptyReturnsTrueForNonEmptyStack()
        {
            var Stack = new Stack<string>(10);
            Stack.Push("a");
            var response = Stack.IsEmpty();
            Assert.IsFalse(response);
        }

        [Test]
        public void InstantiationOfStackWithLessOneThrowsException()
        {
            void a() => new Stack<string>(-1);

            Assert.Throws(typeof(ArgumentException), new TestDelegate(a));
        }
    }
}