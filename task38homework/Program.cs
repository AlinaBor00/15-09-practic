//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffMaxMinNum(double[] array)
{
    double diff = default;
    double max = default;
    double min = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
        else if(array[i] < max) min = array[i];

        diff = max - min; 
    }
    
    return diff;
}

double[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
double diffMaxMinNum = DiffMaxMinNum(arr);
Console.WriteLine(Math.Round(diffMaxMinNum, 1, MidpointRounding.ToZero));