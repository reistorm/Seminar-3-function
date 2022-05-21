// Напишите программу, которая принимает на
// вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

Console.Write("Введите координату х первой точки = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки = ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату х первой точки = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки = ");
int y2 = int.Parse(Console.ReadLine());

int res1 = x1 - x2;
int res2 = y1 - y2;

int result1 = res1 * res1 + res2 * res2;
double result = Math.Sqrt(result1);
Console.WriteLine("{0: 0.000}" ,result);

