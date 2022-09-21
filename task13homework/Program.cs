// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowThirdDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (num <= 1000) do
            {
                int num / 10;
            }
    }
    return num % 10;
}

int showThirdDigit = ShowThirdDigit(number);
