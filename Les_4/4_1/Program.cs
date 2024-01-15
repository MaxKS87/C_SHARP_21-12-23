// 1. Задайте одномерный массив, заполненный случайными
//    числами. Определите количество простых чисел в этом
//    массиве.

using System;

namespace My_4_1
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Array quantity: ");
            int qu_el = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Array lower limit: ");
            int start = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Array upper limit: ");
            int stop = int.Parse(Console.ReadLine()!);

            int[] mass = CreateArrNums(qu_el, start, stop);
            System.Console.WriteLine("Array:");
            Print(mass);
            int simple = CountSimpleNum(mass);
            System.Console.WriteLine("Number of prime numbers:");
            System.Console.WriteLine(simple);
        }

        public static void Print(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)    
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
        }

        public static int[] CreateArrNums(int size, int from, int to)
        {
            int[] arr = new int[size];
            Random n_new = new Random();

            for (int i = 1; i < size; i++)    
                arr[i] = (n_new.Next(from, to));

            return arr;
        }

        public static bool FindSimpleNum (double NN)
        {
            if (NN < 2)
                return false;
            for (int i = 2; i < NN; i++)
            {
                if (NN % i == 0)
                    return false;
            }
            return true;
        }

        public static int CountSimpleNum (int[] arr)
        {
            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (FindSimpleNum(arr[i]))
                {
                    Count++;
                }

            }
            return Count;
        }
        
    }
}