// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default; // default == 0
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

// или

int SumNumbers2(int num)
{
    int sum = default;
    int counter = 1;
    while (counter <= num)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}

int sumNumber = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");