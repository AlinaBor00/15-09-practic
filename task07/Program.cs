// Напишите программу, которая принимает на вход 3х значное число и на выходе показывает его последнюю цифру.

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = n % 10;
Console.WriteLine($"{res}");