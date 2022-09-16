// Напишите программу, которая на вход принимает число и выдает, является ли число четным
// (делится ли оно на 2 без остатка)

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
     Console.WriteLine("No");
}