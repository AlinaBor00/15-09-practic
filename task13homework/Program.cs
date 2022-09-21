// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowThirdDigit(int num)
{
    //int result = 0;
    if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int num2 = 1;
        for (int i = num; num >= 100; i--)
        {
            num2 = num2 * 10;
        }
        result = (num / num2) % 10;
    }
return result;
}
int result = ShowThirdDigit(number);