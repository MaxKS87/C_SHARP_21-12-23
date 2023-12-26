// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int element = Convert.ToInt32(Console.ReadLine ());
if ((element >= 10) && (element <= 99))
{
    if ((element / 10) > (element % 10))
        Console.Write("Наибольшая цифра введённого числа: " + element / 10 + "\n");
    else if ((element / 10) == (element % 10))
        Console.Write("Цифры в числе одинаковы\n");
    else
        Console.Write("Наибольшая цифра введённого числа: " + element % 10 + "\n");
}
else
    Console.Write("Введённое число за пределами требуемого диапазона\n");