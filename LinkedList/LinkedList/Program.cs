using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an option\n 1.Built in Linked List Method\t 2.Add First by creating Method\t3.Add last\t4.append \t5.Delete first node \t6.Search Method\t7.Delete Last node\t8.Display list");
            int option = Convert.ToInt32(Console.ReadLine());
            CustomLinkList linkList = new CustomLinkList();
            switch (option)
            {
                case 1:
                    Console.WriteLine("Built In LinkedList");
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(10);
                    list.AddLast(20);
                    list.AddLast(30);
                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("After removing first element");
                    list.RemoveFirst();
                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    Console.WriteLine("Add First node");

                    linkList.AddFirst(70);
                    linkList.AddFirst(30);
                    linkList.AddFirst(56);
                    break;
                case 3:
                    linkList.AddLastMethod(56);
                    linkList.AddLastMethod(30);
                    linkList.AddLastMethod(70);
                    linkList.Display();
                    break;
                case 4:
                    linkList.Append(70);
                    linkList.Append(30);
                    linkList.Append(56);
                    linkList.Display();
                    break;
                case 5:
                    int result = linkList.DeleteFirstNode();
                    if (result != 0)
                    {
                        Console.WriteLine("{0} is deleted from link list", result);
                    }
                    break;
                case 6:
                    int searchData = linkList.Search(30);
                    if (searchData != 0)
                        Console.WriteLine("{0} is present in the linked list", searchData);
                    break;
                case 7:
                    Console.WriteLine("Delete last node");
                    int lastNode = linkList.DeletelastNode();
                    if (lastNode != 0)
                        Console.WriteLine("{0} is deleted from linked list", lastNode);
                    break;
                case 8:
                    linkList.Display();
                    break;
            }
            
            linkList.Display();
            Console.ReadLine();
        }
    }
}
