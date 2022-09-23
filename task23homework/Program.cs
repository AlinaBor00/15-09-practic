// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"|{counter, 3}|  {counter * counter * counter, 4} |");
        counter++;
    }
}

if (num > 0) Cube(num);
else Console.WriteLine("Введено некорректное число");