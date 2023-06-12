Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double d = double.Parse(Console.ReadLine());

double max = 0;
if (a > b)
{
    if (a > d)
    {
        max = a;
    }
}   
else if (b > d)
{
    if (b > a)
    {
        max = b;
    }
}
else
{
    max = d;
}   
Console.WriteLine($"Максимальное число: {max}");
