// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsAliquot7and23(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0;
}
bool result =  IsAliquot7and23(num);
if (result) Console.WriteLine("Yes");
else Console.WriteLine("No");