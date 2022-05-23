using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }
        public void AddNode(Node node)
        {
            //Check wether list is empty or not then create node as head
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                //if node than add new node as head
                node.next = Head;
                Head = node;
            }
        }
        public void Display()
        {          
            //temp variable will head
            Node temp = Head;
            //Check wether list is empty or not
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                //Check until temp will null
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("-->");
                }
                //for traversing the node
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }

    
}
            
