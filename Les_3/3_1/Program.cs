// Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

using System;

namespace My_3_1
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Количество элементов массива: ");
            int Count = int.Parse(System.Console.ReadLine()!);
            int[] My_mass = new int [Count];

            System.Console.WriteLine("Введите число для проверки: ");
            int My_check = int.Parse(System.Console.ReadLine()!);
            
            int tester = 0;
            Random El_m = new();

            for (int i = 0; i < Count; i++)
            {
                My_mass[i] = El_m.Next(-10, 15);
                System.Console.Write(My_mass[i] + " ");
                if (My_check == My_mass[i])
                    tester++;
            }
            System.Console.WriteLine();
            if ((tester > 0) && (tester % 10 == 2) || (tester % 10 == 3) || (tester % 10 == 4) && (tester != 12) && (tester != 13) && (tester != 14))
                System.Console.WriteLine("Да. {0} раза число {1} встречается в массиве.", tester, My_check);
            else if (tester == 0)
                System.Console.WriteLine("Число {1} не встречается в массиве.", My_check);
            else
                System.Console.WriteLine("Да. {0} раз число {1} встречается в массиве.", tester, My_check);
        }
    }
}