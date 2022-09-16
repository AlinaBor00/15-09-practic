// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число >=1: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int counter = 1; counter <= num; counter++)
     if (counter % 2 == 0)
     Console.WriteLine($"{counter} ");
     

