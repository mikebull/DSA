using DSA.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    [TestFixture]
    public class DataStructureTests
    {
        [Test]
        public void PushSucceeds()
        {
            MyLIFOStack Stack = new MyLIFOStack(10);
            Stack.Push("a");
        }

        [Test]
        public void PushAPeekReturnsA()
        {
            MyLIFOStack stack = new MyLIFOStack(10);
            string element = "a";

            stack.Push(element);
            string result = stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            MyLIFOStack stack = new MyLIFOStack(10);

            stack.Push("a");
            stack.Pop();
            string result = stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            MyLIFOStack stack = new MyLIFOStack(10);

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
            MyLIFOStack stack = new MyLIFOStack(10);

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
            MyLIFOStack stack = new MyLIFOStack(10);

            string result = stack.Pop();
        }

        [Test]
        public void IsEmptyReturnsFalseForEmptyStack()
        {
            MyLIFOStack stack = new MyLIFOStack(10);
            bool response = stack.IsEmpty();
            Assert.IsTrue(response);
        }

        [Test]
        public void IsEmptyReturnsTrueForNonEmptyStack()
        {
            MyLIFOStack stack = new MyLIFOStack(10);
            stack.Push("a");
            bool response = stack.IsEmpty();
            Assert.IsFalse(response);
        }
    }
}