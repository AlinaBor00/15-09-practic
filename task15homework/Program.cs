﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

void WeekendDigit(int num)
{
   if(num > 0 && num < 8)
   {
    if(num == 6 || num == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
   }
   else
   {
       Console.WriteLine("Ошибка. Введите число от 1 до 7!");
   }
}

   WeekendDigit(number);
