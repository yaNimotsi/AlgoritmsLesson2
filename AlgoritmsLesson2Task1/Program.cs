using System;
using System.Collections.Generic;

namespace AlgoritmsLesson2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode();

            //Тест метода AddNode Ожидается последовательность со значениями 1,99,2
            CheckWorkAddNode();
            listNode = null;
            CheckWorkAddNodeAfter();



        }

        /// <summary>
        /// //Тест метода AddNode Ожидается последовательность со значениями 1,99,2
        /// </summary>
        static void CheckWorkAddNode()
        {
            ListNode listNode = new ListNode();

            //Тест метода AddNode Ожидается последовательность со значениями 1,99,2
            listNode.AddNode(1);
            listNode.AddNode(99);
            listNode.AddNode(2);

            Node currentNode = listNode.head;
            string rez = "";
            while (true)
            {
                rez += $"{currentNode.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,99,2,") Console.WriteLine("Корректная работа метода AddNode");
            else Console.WriteLine("Не корректная работа метода AddNode");
        }

        static void CheckWorkAddNodeAfter()
        {
            ListNode listNode = new ListNode();

            //Тест метода AddNode Ожидается последовательность со значениями 1,99,2
            listNode.AddNode(1);
            listNode.AddNode(99);
            listNode.AddNode(2);

            listNode.AddNodeAfter(listNode.head, 3);

            Node currentNode = listNode.head;
            string rez = "";
            while (true)
            {
                rez += $"{currentNode.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,2,") Console.WriteLine("Корректная работа метода AddNodeAfter");
            else Console.WriteLine("Не корректная работа метода AddNodeAfter");

            rez = "";
            listNode.AddNodeAfter(listNode.last, 100);
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,2,100,") Console.WriteLine("Корректная работа метода AddNodeAfter");
            else Console.WriteLine("Не корректная работа метода AddNodeAfter");

            listNode.RemoveNode(4);
            rez = "";
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,100,") Console.WriteLine("Корректная работа метода RemoveNode по индексу");
            else Console.WriteLine("Не корректная работа метода RemoveNode по индексу");
        }
    }
}
