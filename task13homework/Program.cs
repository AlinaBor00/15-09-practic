// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
   int count = 1;
void ShowThirdDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (count <= num) 
            {
                int result = (count / 10) % 10;
            }
            count ++;
    }
}

ShowThirdDigit(number);

//не работает


// int n = 64738;  // /10 = 6473 /10 = 647
// int n2 = 647;  // 647 % 10 = 5
