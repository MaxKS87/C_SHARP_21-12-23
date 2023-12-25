// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Write("Введём абсциссу точки (X): ");
int x = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введём ординату точки (Y): ");
int y = Convert.ToInt32(Console.ReadLine ());

if ((x > 0) && (y > 0))
    Console.Write("Точка в первой четверти\n");
else if ((x < 0) && (y > 0))
    Console.Write("Точка во второй четверти\n");
else if ((x < 0) && (y < 0))
    Console.Write("Точка в третьей четверти\n");
else if ((x > 0) && (y < 0))
    Console.Write("Точка в четвёртой четверти\n");
else if ((x == 0) && (y == 0))
    Console.Write("Точка в центре координат\n");
else
    Console.Write("Точка лежит на одной из осей\n");