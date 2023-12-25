// 3. Напишите программу, которая будет принимать на вход два
//    числа и выводить, является ли второе число кратным первому.
//    Если второе число некратно первому, то программа выводит
//    остаток от деления.

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine ());
if (num2 % num1 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Остаток от деления " + num2 % num1);
}