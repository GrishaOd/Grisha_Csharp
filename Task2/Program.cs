// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double d = double.Parse(Console.ReadLine());

double max = a;
if (b > max)
{
    max = b;
}   

if (d > max)
{
   max = d;
}
  
Console.WriteLine($"Максимальное число: {max}");
