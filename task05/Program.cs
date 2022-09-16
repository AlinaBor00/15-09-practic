// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числав промежутке
// от -N до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = -number;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}
