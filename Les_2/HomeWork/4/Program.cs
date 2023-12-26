// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.


Console.Write("Пожалуйста введите натуральное число: ");
int element = Convert.ToInt32(Console.ReadLine ());
// Можно ли использовать тип uint (подсмотрел его диапазон)?

string set_of_num = "";
if (element > 0)
{
    while (element > 0)
    {
        set_of_num = element % 10 + "," + set_of_num;
        element = element / 10;
    }
    // set_of_num = set_of_num.Trim({ ',' });
    Console.Write(set_of_num.Trim(',') + "\n");
}
else
    Console.Write("Ну просили же ввести НАТУРАЛЬНОЕ число...\n");