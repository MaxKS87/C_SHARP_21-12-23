// Задача 3.
// Заполните массив на N случайных целых чисел от 0 до 9.
// Числа вводятся с консоли, не более 8.
// Сформируйте целое число, состоящее из элементов массива.
// Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array size (max 8)");
        int size = Convert.ToInt32(Console.ReadLine());
        Print(" ");
        
        if (size > 8)
        {
            Print("Error! Array size will be limited to 8");
            size = 8;
        }

        int[] arr = GenerateRandomArray(size, 1, 10);

        // Вывод массива в консоль для проверки
        for (int i = 0; i < arr.Length; i++)
            Print($"Element {i}: " + arr[i]);

        Print(" ");

        int res = MakeInteger(arr, size);
        Print("Number : " + res);
        Print(" ");
    }

/// <summary>
/// Функция выводящая результат на экран
/// </summary>
/// <param name="res"></param>
    static void Print(string res)
    { 
        Console.WriteLine(res);
    }

/// <summary>
/// Создаём массив случайных чисел
/// </summary>
/// <param name="size"></param>
/// <param name="min_val"></param>
/// <param name="max_val"></param>
/// <returns>Массив</returns>
    static int[] GenerateRandomArray(int size, int min_val, int max_val)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(min_val, max_val);
        }
        return arr;
    }

/// <summary>
/// Собираем число из массива
/// </summary>
/// <param name="arr"></param>
/// <param name="size"></param>
/// <returns>Искомое число</returns>
    static int MakeInteger(int[] arr, int size)
    {
        int result = 0;
        for (int i = 0; i < size; i++)
            result = result * 10 + arr[i];
        return result;
    }

}