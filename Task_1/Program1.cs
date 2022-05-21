// Написать программу при вводе значений определить
// номер плоскости

Console.WriteLine("Введите значение х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0 )
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0 )
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0 )
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0 )
{
    Console.WriteLine("Четвертая четверть");
}
