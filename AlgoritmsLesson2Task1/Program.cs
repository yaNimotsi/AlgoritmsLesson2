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

            var str = Console.ReadLine();

            while (str.Length > 0)
            {
                int.TryParse(Console.ReadLine(), out int userVal);

                //Node node = new Node(userVal);

                listNode.AddNode(userVal);
            }
        }
    }
}
