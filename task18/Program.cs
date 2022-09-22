// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
//координат точек в этой четверти (х и у)

Console.WriteLine("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Coordinates(int n)
{
    if (n == 1) return "x > 0, y > 0";
    if (n == 2) return "x < 0, y > 0";
    if (n == 3) return "x < 0, y < 0";
    if (n == 4) return "x > 0, y < 0";
    return "Введены некорректные данные ";
}

string coordinates = Coordinates(quarter);
Console.WriteLine(coordinates);

