// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

using System;

namespace My_3_2
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Количество элементов массива: ");
            int Count = int.Parse(System.Console.ReadLine()!);
            int[] My_mas_inv = new int [Count];
            
            Random El_m_inv = new();

            System.Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < Count; i++)
            {
                My_mas_inv[i] = El_m_inv.Next(-10, 10);
                System.Console.Write(My_mas_inv[i] + " "); // Эта строка пригодится для проверки
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Инвертированный массив: ");
            for (int j = 0; j < Count; j++)
            {
                if (My_mas_inv[j] < 0)
                    My_mas_inv[j] = Math.Abs(My_mas_inv[j]);
                else if (My_mas_inv[j] > 0)
                    My_mas_inv[j] = - My_mas_inv[j];
                System.Console.Write(My_mas_inv[j] + " ");
            }
            System.Console.WriteLine();
        }    
    }
}