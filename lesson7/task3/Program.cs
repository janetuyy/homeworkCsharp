// See https://aka.ms/new-console-template for more information
/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.WriteLine("Hi, dear!");

int[,] arr = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

for (int i = 0; i < arr.GetLength(1); i++)
{
    double s = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        s += arr[j, i];
    }
    Console.WriteLine($"{Math.Round(s / arr.GetLength(0), 1)} ");
}
