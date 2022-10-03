// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool CkeckTriangle(int number1, int number2, int number3)
{
    return(number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2);

}

if(CkeckTriangle(num1, num2, num3)) Console.WriteLine("Такой треугольник существует");
else Console.WriteLine("Такой треугольник не существует");