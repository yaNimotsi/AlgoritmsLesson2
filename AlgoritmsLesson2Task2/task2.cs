using System;

namespace AlgoritmsLesson2Task2
{
    class task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Если искомое число находится посередние то сложность составит 1
        //Если же болшьше 1, то для каждого прохода while сложность будет сокращаться на половину
        //Т.е. 1 круг n
        //2 круг n/2
        //3 круг n/2/2 т.е. n/2^2
        //.
        //.
        //.
        //для круга k это составит n/2^k
        //Как это свести к Log(n), которое прозвучало на вебинаре - не понимаю. Видимо надо вспоминать школьный курс математики
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[min])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
