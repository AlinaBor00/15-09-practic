// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456-> 5
//782-> 8
//918-> 1

Console.WriteLine("Введите трёхзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int num)
{
    int secondDigit = num / 10;
    return secondDigit % 10;
}

int result = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} => {result}");