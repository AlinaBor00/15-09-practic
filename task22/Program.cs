// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Square(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"|{counter, 5}|  {counter * counter, 5} |");
        counter++;
    }
}

if (num > 0) Square(num);
else Console.WriteLine("Введено некорректное число");