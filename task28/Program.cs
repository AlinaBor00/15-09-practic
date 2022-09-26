// Напишите программу, которая принимает на вход число N и 
//выдает произведение чисел от 1 до N


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multipl(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}

if(number > 0)
{
    int multipl = Multipl(number);
    Console.WriteLine(($"Произведение чисел от 1 до {number} = {multipl}"));
}
else Console.WriteLine("Введено некорректное значение");