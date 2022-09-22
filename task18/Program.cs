// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
 //координат точек в этой четверти (х и у)

Console.WriteLine("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
 
void Coordinates(int n)
{
    if(n == 1) Console.WriteLine("x > 0, y > 0");
    else if(n == 2) Console.WriteLine("x < 0, y > 0");
    else if(n == 3) Console.WriteLine("x < 0, y < 0");
    else if(n == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Введены некорректные данные ");
}

 Coordinates(quarter);
 