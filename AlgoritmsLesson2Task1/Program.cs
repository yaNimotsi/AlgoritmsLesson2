using System;
using System.Collections.Generic;

namespace AlgoritmsLesson2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node startNode = new Node(0)
            {
                PrevNode = null
            };
            Node endNode = new Node(1)
            {
                NextNode = null
            };

            ListNode listNode = new ListNode(startNode, endNode);
            
            listNode.AddNode(1);
            listNode.AddNode(99);

            listNode.AddNode(2);
        }
    }
}
