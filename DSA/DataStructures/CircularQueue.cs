using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class CircularQueue
    {
        public string[] Elements { get; set; }

        public CircularQueue(int size)
        {
            if (size > 0) Elements = new String[size]; 
        }

        public void Add(string element)
        {
            
        }
    }
}
