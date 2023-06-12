// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
double max = 0;
double min = 0;
if (a > b)
{
    max = a;
    min = b;
}   
else 
{
    max = b;
    min = a;
}   
Console.WriteLine($"Большее число: {max}");
Console.WriteLine($"Меньшее число: {min}");

