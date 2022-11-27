// See https://aka.ms/new-console-template for more information
/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*Console.WriteLine("Hello, kitty!");

int[,] arr = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int s="";

int[] arr2={2, 5, 1, 9};
for (int i=0; i< arr.GetLength(0); i++)
{
s+=arr2[i];
    Array.Sort(arr2);
    Array.Reverse(arr2);
    
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}");
        if (j < arr.GetLength(1) - 1)
        {
            Console.Write(" | ");
        }
    }
    Console.WriteLine("]");
}*/
/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/
Console.WriteLine("Hello, kitty!");
int[,] arr(int m, int n)
{
    int[,] localArr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < localArr.GetLength(0); i++)
    {
        for (int j = 0; j < localArr.GetLength(1); j++)
        {
            localArr[i, j] = random.Next(1, 10);
        }
    }
    return localArr;
}

void PrintArray(int[,] localArr)
{
    for (int i = 0; i < localArr.GetLength(0); i++)
    {
        
        for (int j = 0; j < localArr.GetLength(1); j++)
        {
            Console.Write($"{localArr[i, j]}");
            if (j < localArr.GetLength(1) - 1)
            {
                Console.Write(" ");
            }
        }
        
        Console.WriteLine();
    }
}

int[,] CalculateArray(int[,] localArr)
{
    int temp;
    for (int rows = 0; rows < localArr.GetLength(0); rows++)
        for (int i = 0; i < localArr.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < localArr.GetLength(1); j++)
            {
                if (localArr[rows, i] < localArr[rows, j])
                {
                    temp = localArr[rows, i];
                    localArr[rows, i] = localArr[rows, j];
                    localArr[rows, j] = temp;
                }
            }
        }

    return localArr;
}

int[,] array = arr(3, 4);
PrintArray(array);

Console.WriteLine();

array = CalculateArray(array);
PrintArray(array);