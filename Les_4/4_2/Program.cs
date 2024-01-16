// 2. Задайте массив из N случайных целых
//    чисел (N вводится с клавиатуры).
//    Найдите количество чисел, которые
//    оканчиваются на 1 и делятся нацело на 7.

using System;

namespace My_4_2
{
    class Program
    {
        static void Main()
        {
            Print("Enter array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine()!);
            Print("Array lower limit: ");
            int start = int.Parse(Console.ReadLine()!);
            Print("Array upper limit: ");
            int stop = int.Parse(Console.ReadLine()!);
            Print(" ");

            int[] myArrNums = CreateRandArrNums(arrSize, start, stop);
            foreach (var item in myArrNums)
                Print($"Element {item} ");
            string result = Convert.ToString(FindArrEl(myArrNums));
            Print(result);

        }

        // Для вывода данных
        public static void Print(string finalRes)
        {
            Console.WriteLine(finalRes);
        }

        // Random массив
        public static int[] CreateRandArrNums(int size, int from, int to)
        {
            int[] arr = new int[size];
            Random n_new = new Random();

            for (int i = 1; i < size; i++)    
                arr[i] = (n_new.Next(from, to));

            return arr;
        }
        
        // Ищем элемент по условию
        static int FindArrEl(int[] arr)
        {
            int specPriv = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
                    specPriv++;
            }
            return specPriv;
        }

    }
}