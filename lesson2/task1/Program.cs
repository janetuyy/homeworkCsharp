// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("write 3th char numer");
int a=0;
try
{
a=Convert.ToInt32(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}
a=a/10;
a=a%10;
Console.WriteLine($"num={a}");