// See https://aka.ms/new-console-template for more information
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Hello, i'll tell u smthng!");
int sum =0;
string n="";
int[] array = new int[4];
for (int i=0; i<4; i++)
{
    array[i] =  new Random().Next(0, 100);
    if (i%2==0)
    {
        sum+=array[i];
    }
}
foreach (double item in array)
{
n += $"{item}, ";
}
n=n.TrimEnd(' ');
n=n.TrimEnd(',');

Console.WriteLine(n);

Console.WriteLine(sum);