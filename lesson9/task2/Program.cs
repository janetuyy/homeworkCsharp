// See https://aka.ms/new-console-template for more information
/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Hello, lucky!");
int sum=0;
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());

int numbers(int m, int n)
{
    while (m<=n)
    {
        sum+=m;
        m+=1;
    }
    return sum;
}
    Console.Write(numbers(m, n));
