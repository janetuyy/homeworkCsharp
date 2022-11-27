// See https://aka.ms/new-console-template for more information
/*  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Hey, cutie!");

int[,] arr= new int[4,4] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};
int minsum=0;
int minstring=0;
for (int i=0; i< arr.GetLength(0); i++)
{
    int s=0;
    for (int j=0; j< arr.GetLength(1); j++)
    {
        s+=arr[i,j];
    }
    if (s < minsum | minsum==0)
    {
        minsum=s;
        minstring=i+1;
    }

}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minstring} строка");