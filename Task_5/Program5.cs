﻿// Напишите программу, которая
// принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("|{0,10}|{1,10}|", "Число", "Корень");
for (int i = 1; i <= length; i++) 
Console.WriteLine("|{0,10}|{1,10}|", i, i*i);   



