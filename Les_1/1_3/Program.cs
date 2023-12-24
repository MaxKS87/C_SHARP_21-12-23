// Написать программу, которая принимает на вход трёхзначное
// целое число и на выходе показывает сумму первой и
// последней цифры этого числа.


Console.Write("Enter your three-digit number: ");
int Num_3d = int.Parse(Console.ReadLine()!);
Num_3d = Num_3d / 100 + Num_3d % 10;
Console.WriteLine(Num_3d);