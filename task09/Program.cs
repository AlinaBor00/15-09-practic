﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наиб цифру числа
// 78 -> 8
// 12 -> 2


//int number = new Random().Next(10, 100);
//Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//if(firstDigit == secondDigit) Console.WriteLine("Цифры равны");
//else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");


//int maxDigit = firstDigit;
//if(secondDigit > firstDigit) maxDigit = secondDigit;


//int maxDigit1 = firstDigit > secondDigit ? firstDigit : secondDigit;


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}


int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");
