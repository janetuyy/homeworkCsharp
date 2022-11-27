// See https://aka.ms/new-console-template for more information
/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/
Console.WriteLine("Hello, deer!");
int[,] arr1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] arr2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };
int[,] res = new int[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        int counter = 0;
        for (int k = 0; k < 2; k++)
        {
            counter += arr1[i, k] * arr2[k, j];
        }
        res[i, j] = counter;
    }
}
for (int i = 0; i < res.GetLength(0); i++)
{

    for (int j = 0; j < res.GetLength(1); j++)
    {
        Console.Write($"{res[i, j]}");
        if (j < res.GetLength(1) - 1)
        {
            Console.Write(" ");
        }
    }

    Console.WriteLine();
}