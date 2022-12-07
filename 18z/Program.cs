Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 4 || n < 1)
{
    Console.WriteLine("Введена неверная четверть, введите ещё раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.WriteLine("Возможные координаты: x > 0, y > 0");
else if (n == 2)
Console.WriteLine("Возможные координаты: x < 0, y > 0");
else if (n == 3)
Console.WriteLine("Возможные координаты: x < 0, y < 0");
else
Console.WriteLine("Возможные координаты: x > 0, y < 0");