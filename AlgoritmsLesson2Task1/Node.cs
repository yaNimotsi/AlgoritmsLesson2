using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsLesson2Task1
{
    public class Node
    {
        int nodeValue;
        Node nextNode;
        Node prevNode;

        public int Value { get { return nodeValue; } set { nodeValue = Value; } }
        public Node NextNode { get { return nextNode; } set { nextNode = value; } }
        public Node PrevNode { get { return prevNode; } set { prevNode = value; } }

        public Node(int value)
        {
            nodeValue = value;
        }
    }
}
