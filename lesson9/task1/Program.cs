// See https://aka.ms/new-console-template for more information
/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Hello, my fav person!");

int numbers(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return 1;
    else return numbers(n - 1);

}
numbers(Convert.ToInt32(Console.ReadLine()));

