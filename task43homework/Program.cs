// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void Intersection(double argB1, double argK1, double argB2, double argK2)
{
   double x = ((-argB2 + argB1) / (-argK1 + argK2));
   double y = (argK2 * x + argB2);
   Console.WriteLine($"Пересечение в точке: ({x} ; {y})");
}
 
if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if(k1 == k2) Console.WriteLine("Прямые параллельны");
else Intersection(b1, k1, b2, k2);



 
