// See https://aka.ms/new-console-template for more information
/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Hello, honey!");
int[,,] arr = new int[2, 2, 2];

Random rnd = new Random();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            arr[i, j, k] = rnd.Next(10, 100);
            Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();

    }

}

