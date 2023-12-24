// 2. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
if (b1 > 0)
{
    int count = -b1;
    while (count <= b1)
    {
        Console.Write(count+" ");
        count++;
        
    }
}
else if (b1 < 0)
{
    int count = -b1;
    while (count >= b1)
    {
        Console.Write(-count+" ");
        count--;
        
    }
}
else
{
    Console.Write("Your nomber - ZERO!");
}