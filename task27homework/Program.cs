//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int digit = 0;
    int sum = 0;
    while(num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10; 
    }
    return sum;
}

int sumNumber = Sum(Math.Abs(number));
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumber}");