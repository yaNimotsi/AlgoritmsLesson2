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
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,99,2,") Console.WriteLine($"Корректная работа метода AddNode. Ожидали 1,99,2, Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода AddNode. Ожидали 1,99,2, Получили {rez}");
        }

        static void CheckWorkAddNodeAfter()
        {
            ListNode listNode = new ListNode();

            //Тест метода AddNode Ожидается последовательность со значениями 1,99,2,3
            listNode.AddNode(1);
            listNode.AddNode(99);
            listNode.AddNode(2);

            listNode.AddNodeAfter(listNode.head, 3);

            Node currentNode = listNode.head;
            string rez = "";
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,2,") Console.WriteLine($"Корректная работа метода AddNodeAfter. Ожидали 1,3,99,2, Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода AddNodeAfter. Ожидали 1,3,99,2, Получили {rez}");

            rez = "";
            listNode.AddNodeAfter(listNode.last, 100);
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,2,100,") Console.WriteLine($"Корректная работа метода AddNodeAfter. Ожидали 1,3,99,2,100 Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода AddNodeAfter. Ожидали 1,3,99,2,100 Получили {rez}");


            //FindNode
            var node = listNode.FindNode(99);
            if (node.Value == 99) Console.WriteLine($"Корректная работа метода FindNode. Ожидалось 99, получили {node.Value}");
            else Console.WriteLine($"Не корректная работа метода FindNode. Ожидалось 99, получили {node.Value}");

            node = listNode.FindNode(100);
            if (node.Value == 100) Console.WriteLine($"Корректная работа метода FindNode. Ожидалось 100, получили {node.Value}");
            else Console.WriteLine($"Не корректная работа метода FindNode. Ожидалось 100, получили {node.Value}");

            if (listNode.Count == 5) Console.WriteLine($"Корректная работа метода FindNode. Ожидалось 5, получили {listNode.Count}");
            else Console.WriteLine($"Не корректная работа метода FindNode. Ожидалось 5, получили {listNode.Count}");

            listNode.RemoveNode(4);
            rez = "";
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,100,") Console.WriteLine($"Корректная работа метода RemoveNode по индексу. Ожидали 1,3,99,100 Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода RemoveNode по индексу. Ожидали 1,3,99,100 Получили {rez}");

            listNode.RemoveNode(4);
            rez = "";
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null) break;
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,3,99,") Console.WriteLine($"Корректная работа метода RemoveNode по индексу. Ожидали 1,3,99, Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода RemoveNode по индексу. Ожидали 1,3,99, Получили {rez}");


            if (listNode.Count == 3) Console.WriteLine($"Корректная работа метода FindNode. Ожидалось 3, получили {listNode.Count}");
            else Console.WriteLine($"Не корректная работа метода FindNode. Ожидалось 3, получили {listNode.Count}");

            rez = "";
            currentNode = listNode.head;

            listNode.RemoveNode(listNode.last.PrevNode);
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null)
                {
                    break;
                }
                else currentNode = currentNode.NextNode;
            }

            if (rez == "1,99,") Console.WriteLine($"Корректная работа метода RemoveNode по ноду. Ожидали 1,99, Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода RemoveNode по ноду. Ожидали 1,99, Получили {rez}");

            rez = "";
            

            listNode.RemoveNode(listNode.head);
            currentNode = listNode.head;
            while (true)
            {
                rez += $"{currentNode?.Value},";
                if (currentNode.NextNode == null || listNode.Count <= 2) break;
            }

            if (rez == "99,") Console.WriteLine($"Корректная работа метода RemoveNode по ноду. Ожидали 99, Получили {rez}");
            else Console.WriteLine($"Не корректная работа метода RemoveNode по ноду. Ожидали 99, Получили {rez}");
        }
    }
}
