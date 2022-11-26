// See https://aka.ms/new-console-template for more information
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.WriteLine("start!");

int y = 0;
int x = 0;

Console.Write("y= ");
try
{
    x = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("there is no answer");
    Environment.Exit(0);
}

Console.Write("x= ");
try
{
    y = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("there is no answer");
    Environment.Exit(0);
}

int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

int height = array.GetLength(0);
int width = array.GetLength(1);

for (int i=0; i < height; i++)
{
    for (int j=0; j< width; j++)
    {
        Console.Write(array[i,j]+ "\t");
    }
    Console.WriteLine();
}

if (y > height | x > width | x < 0 | y < 0 )
{
    Console.WriteLine("there is no answer");
}
else
{
    Console.WriteLine("ur number is " + array[x, y]);
}
