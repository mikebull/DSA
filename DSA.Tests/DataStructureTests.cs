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
            MyStack Stack = new MyStack();
            Stack.Push("a");
        }

        [Test]
        public void PushAPeekReturnsA()
        {
            MyStack stack = new MyStack();
            string element = "a";

            stack.Push(element);
            string result = stack.Peek();

            Assert.AreEqual(element, result);
        }

        [Test]
        public void PushAPopPeekReturnsNull()
        {
            MyStack stack = new MyStack();

            stack.Push("a");
            stack.Pop();
            string result = stack.Peek();

            Assert.Null(result);
        }

        [Test]
        public void PushAPushBPopPeekReturnsA()
        {
            MyStack stack = new MyStack();

            string firstPush = "a";
            string secondPush = "b";

            stack.Push(firstPush);
            stack.Push(secondPush);
            stack.Pop();
            string result = stack.Peek();

            Assert.AreEqual(firstPush, result);

        }
    }
}