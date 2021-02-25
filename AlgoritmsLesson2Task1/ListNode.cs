using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsLesson2Task1
{
    class ListNode : ILinkedList
    {
        Node head;
        Node last;
        private int count;

        public ListNode(Node startNode, Node endNode)
        {
            head = startNode;
            last = endNode;
        }

        public int GetCount()
        {
            return count;
        }

        public void AddNode(int value)
        {
            switch (count)
            {
                case 0: //Нодов нет
                    head = new Node(value);

                    head.PrevNode = null;
                    head.NextNode = null;
                    break;
                case 1: //Всего 1 нод
                    if(head != null)
                    {
                        last = new Node(value);

                        head.NextNode = last;
                        last.PrevNode = head;
                    }
                    else
                    {
                        head = new Node(value);

                        head.NextNode = last;
                        last.PrevNode = head;
                    }
                    break;
                default:    //Прочие ситуации
                    Node newNode = new Node(value);

                    last.NextNode = newNode;

                    newNode.PrevNode = last;
                    newNode.NextNode = null;

                    last = newNode;                    
                    break;
            }
            count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == last)
            {
                Node nextNode = new Node(value);
                nextNode.NextNode = null;
                nextNode.PrevNode = last;

                last.NextNode = nextNode;
                last = nextNode;
            }
            else
            {
                Node nextNode = node.NextNode;
                Node newNode = new Node(value);

                nextNode.PrevNode = newNode;
                node.NextNode = node;

                newNode.PrevNode = node;
                newNode.NextNode = nextNode;
            }

            count++;
        }

        public void RemoveNode(int index)
        {
            if (index > count) return;

            Node currenNode = head;
            int counter = 0;

            while (currenNode != null)
            {
                if (counter == index)
                {
                    Node prevNode = currenNode?.PrevNode;
                    Node nextNode = currenNode?.NextNode;

                    if (nextNode != null) prevNode.NextNode = null;
                    if (prevNode != null) nextNode.PrevNode = null;
                }
                counter++;
            }

            count--;
        }

        public void RemoveNode(Node node)
        {
            Node nextNode = node?.NextNode;
            Node prevNode = node?.PrevNode;

            if (nextNode == null && prevNode == null) return;

            if (count > 2)
            {
                if (nextNode != null) prevNode.NextNode = null;
                if (prevNode != null) nextNode.PrevNode = null;
            }

            count--;
        }

        public Node FindNode(int searchValue)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                    return currentNode;

                currentNode = currentNode.NextNode;
            }

            return null;
        }
    }
}
