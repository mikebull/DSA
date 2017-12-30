using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class MyStack
    {
        private int _top = 0;
        private string[] _element = new string[2];

        public void Push(string element)
        {
            _element[_top] = element;
            _top++;
        }

        public string Peek()
        {
            if (_top == 0) return _element[_top];
            else return _element[_top - 1];
        }

        public void Pop()
        {
            _element[_top - 1] = null;
            _top--;
        }
    }
}
