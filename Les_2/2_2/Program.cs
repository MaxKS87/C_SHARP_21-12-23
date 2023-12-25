// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine ());

if (num >= 100 && num < 1000)
{
    int num1 = num % 100 / 10;
    int num2 = num % 10;
    double  result = Math.Pow(num1,num2);
    Console.WriteLine(result);
}
else
{
    if (num < 100 || num > 1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}