// Программа, которая на вход принимает координаты точки X,Y , прричем они не равны 0 и выдает номер 
//четверти плоскости, в которой находится эта точка


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Введены некорректные координаты" : quarter);