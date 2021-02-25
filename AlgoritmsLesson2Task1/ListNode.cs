using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsLesson2Task1
{
    class ListNode : ILinkedList
    {
        public Node head;
        public Node last;
        private int count;

        public ListNode(Node startNode, Node endNode)
        {
            head = startNode;
            last = endNode;
        }
        public ListNode(){}

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
                Node newNode = new Node(value);
                newNode.PrevNode = node;
                newNode.NextNode = node.NextNode;

                Node nextNode = node.NextNode;
                nextNode.PrevNode = newNode;
                node.NextNode = newNode;
            }

            count++;
        }

        public void RemoveNode(int index)
        {
            if (index > count) return;

            if (count == 1)
            {
                head = null;    //Удаляется единственный эллемент списка
                last = null;
            }
            else if (count == 2)
            {
                if (index == 1) //Удаляется начало
                {
                    head = last;
                    head.NextNode = null;

                    last = null;
                }
                else    //Удаляется конец
                {
                    head.NextNode = null;

                    last = null;
                }
            }
            else if (count == index)    //Удаляем последний эллемент
            {
                last = last.PrevNode;
                last.NextNode = null;
            }
            else
            {
                Node currenNode = head;
                int counter = 1;

                while (currenNode != null)
                {
                    if (counter == index)
                    {
                        Node prevNode = currenNode?.PrevNode;
                        Node nextNode = currenNode?.NextNode;

                        //if (nextNode != null) prevNode.NextNode = null;
                        //if (prevNode != null) nextNode.PrevNode = null;

                        prevNode.NextNode = nextNode;
                        nextNode.PrevNode = prevNode;
                        break;
                    }

                    currenNode = currenNode.NextNode;

                    counter++;
                }
            }

            count--;
        }

        public void RemoveNode(Node node)
        {
            Node nextNode = node.NextNode;
            Node prevNode = node.PrevNode;

            if (nextNode == null && prevNode == null)
            {
                head = null;
                last = null;

                count--;

                return;
            }

            if (nextNode == null)
            {
                if (prevNode != null)
                {
                    prevNode.NextNode = null;
                    last = prevNode;
                }
            }
            else
            {
                if(prevNode != null) prevNode.NextNode = nextNode;
            }

            if (prevNode == null)
            {
                if (nextNode != null)
                {
                    nextNode.PrevNode = null;
                    head = nextNode;
                }
            }
            else
            {
                if (nextNode != null) nextNode.PrevNode = prevNode;
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
