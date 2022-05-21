// Напишите программу, которая принимает на
// вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве 
// с использованием массива

Console.WriteLine("Введите последовательно координаты X и Y для первой точки");
int count;
double [] pointA = new double [2];
for (count = 0; count < 2; count ++)
{
pointA[count] = Convert.ToDouble(Console.ReadLine());

}
Console.WriteLine("Введите последовательно координаты X и Y для второй точки");
double [] pointB = new double [2];
for (count = 0; count < 2; count ++) {
    pointB[count] = Convert.ToDouble(Console.ReadLine());

}
Console.WriteLine("Ваши точки: А (" + pointA[0] + "; " + pointA[1] + "), B(" + pointB[0] + "; " + pointB[1] + ")");

double result;
double Distance(double[] pointA, double[] pointB)
{
    result = Math.Sqrt((pointB[0] - pointA[0]) * (pointB[0] - pointA[0]) + (pointB[1] - pointA[1]) * (pointB[1] - pointA[1]));
    return result;
}

double dist = Distance(pointA, pointB);
Console.WriteLine("Расстояние между двумя точками равно " + "{0: 0.000}" ,dist);

Console.WriteLine("Повторный вызов метода");
double repeat = Distance(pointA, pointB);
Console.Write("{0: 0.000}" ,repeat);
