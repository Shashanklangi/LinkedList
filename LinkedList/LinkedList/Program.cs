﻿namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            list.AddNode(node1);
            list.AddNode(node2);
            list.AddNode(node3);
            list.Display();
        }
    }
}