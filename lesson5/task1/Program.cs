// See https://aka.ms/new-console-template for more information
/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
Console.WriteLine("Hello, World!");
int s=0;
string n="";
int[] array = new int[10];
for (int i=0; i < 10; i++)
{
array[i]=new Random().Next(100, 1000);
if (array[i]%2==0)
s+=1;
}
foreach (double item in array)
{
    n += $"{item}, ";
}

n = n.TrimEnd(' ');
n = n.TrimEnd(',');
Console.WriteLine(n);
Console.WriteLine(s);