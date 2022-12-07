Console.Clear();
Console.WriteLine("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
    Console.WriteLine("Не верная координата!\nВведите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.WriteLine("Не верная координата!\nВведите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("1 четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("2 четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("3 четверть");
else
    Console.WriteLine("4 четверть");