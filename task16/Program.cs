// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно
//число квадратом другого.
//5, 25 -> да
//-4, 16 -> да

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int arg1, int arg2)
{
    return arg1 == arg2 * arg2 || arg2 == arg1 *arg1;
}
bool result =  IsSquare(num1, num2);
if (result) Console.WriteLine($"{num1}, {num2} => Yes");
else Console.WriteLine($"{num1}, {num2} => No");
