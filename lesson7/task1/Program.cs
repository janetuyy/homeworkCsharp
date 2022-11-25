﻿// See https://aka.ms/new-console-template for more information
/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("let's go!");
Console.Write("m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n= ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Random rnd = new Random();
        array[i, j] = Convert.ToDouble ( Math.Round((rnd.NextDouble() * (10-(-10))+(-10)), 1) );
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
