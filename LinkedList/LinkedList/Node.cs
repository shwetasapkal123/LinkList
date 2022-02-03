using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        //instance variable
        public int data;
        public Node next;

        //Paramateralised constructor
        public Node(int data)       
        {
            this.data = data;
            next = null;
        }
    }
}
