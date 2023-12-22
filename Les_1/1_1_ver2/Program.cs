// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// Вариант --2--

Console.Write("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b2 = int.Parse(Console.ReadLine()!);

if (b2 * b2 == b1)
Console.WriteLine("Yes");
else
Console.WriteLine("No");
