using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class CustomLinkList
    {
        //create head node to point first element
        public Node head;

        //create method to add at last bca stack operate on LIFO
        public void AddLastMethod(int newData)
        {
            //object of Node constructor
            Node newNode = new Node(newData);
            if (this.head == null)
                this.head = newNode;
            else
               {
                 Node temp = head;
                  while (temp.next != null)
                  {
                    temp = temp.next;
                   }
                this.head.next = newNode;
                }
            Console.WriteLine("Added in the List " + newNode.data);
        }

        public void AddFirst(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} inserted into list ",newNode.data);
        }

        public void Append(int newdata)
        {
            AddLastMethod(newdata);
        }

        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list Empty");
                return 0;
            }

            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
        }

        public int DeletelastNode()
        {
            Node newNode=this.head;
            if(this.head == null)
            {
                Console.WriteLine("linked list empty");
                return 0;
            }
            if(this.head.next ==null)
            {
                this.head = null;
                return 0;
            }
            while(newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastDeleteNode = newNode.next.data;
            newNode.next = null;
            return lastDeleteNode;
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("no values to display");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("value in linked list: " + temp.data);
                temp = temp.next;
            }
        }

        public int Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                    return value;

                temp = temp.next;
            }
            Console.WriteLine("{0} is not present",value);
            return 0;
        }
    }
}
