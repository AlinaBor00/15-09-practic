// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 2д пространстве
// A(3,6) B(2,1) -> 5,09

//Math.Pow(2, 10);
// double num = Math.Sqrt(10);
// // 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);


Console.WriteLine("Введите x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argX1, int argY1, int argX2, int argY2)
{
    double res1 = argX2 - argX1;
    double res2 = argY2 - argY1;
    double result = Math.Sqrt(Math.Pow(res1, 2) + Math.Pow(res2, 2));
    return result;
}


double distance = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.Write(distance);