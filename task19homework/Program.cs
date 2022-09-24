// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000;
int num2 = number % 10000 / 1000;
int num4 = number % 100 / 10;
int num5 = number % 10;


if (number >= 10000 && number < 100000) Palindrome(number);
else Console.WriteLine("Введено некорректное число");


void Palindrome(int num)
{ 
    if(num1 == num5) 
    { 
        if(num2 == num4)
        {
           Console.WriteLine("Палиндром"); 
        }
        else Console.WriteLine("Не палиндром");
    } 
    else Console.WriteLine("Не палиндром");
}


