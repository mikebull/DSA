using DSA.DataStructures;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            LIFOStack stack = new LIFOStack(10);
            string element = "a";

            stack.Push(element);
            string result = stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            LIFOStack stack = new LIFOStack(10);

            stack.Push("a");
            stack.Pop();
            string result = stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            LIFOStack stack = new LIFOStack(10);

            string firstPush = "a";
            string secondPush = "b";

            stack.Push(firstPush);
            stack.Push(secondPush);
            stack.Pop();
            string result = stack.Peek();

            Assert.AreEqual(firstPush, result);
        }

        [Test]
        public void PushPushPushPushPopPopPeekkReturnsSecondPush()
        {
            LIFOStack stack = new LIFOStack(10);

            string firstPush = "a";
            string secondPush = "b";
            string thirdPush = "c";
            string fourthPush = "d";

            stack.Push(firstPush);
            stack.Push(secondPush);
            stack.Push(thirdPush);
            stack.Push(fourthPush);
            stack.Pop();
            stack.Pop();
            string result = stack.Peek();
            Assert.AreEqual(result, secondPush);
        }

        [Test]
        public void PopEmptyStackReturnsNull()
        {
            LIFOStack stack = new LIFOStack(10);

            string result = stack.Pop();
        }

        [Test]
        public void IsEmptyReturnsFalseForEmptyStack()
        {
            LIFOStack stack = new LIFOStack(10);
            bool response = stack.IsEmpty();
            Assert.IsTrue(response);
        }

        [Test]
        public void IsEmptyReturnsTrueForNonEmptyStack()
        {
            LIFOStack stack = new LIFOStack(10);
            stack.Push("a");
            bool response = stack.IsEmpty();
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