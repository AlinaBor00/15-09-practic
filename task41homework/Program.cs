//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите числа (через пробел): ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Quantity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int quantity = Quantity(numbers);
Console.WriteLine($"Количество чисел больше 0: {quantity}");