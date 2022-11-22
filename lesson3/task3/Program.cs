// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Hello, can u tell me a num?");
int a = 0;
try
{
    a = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("error: incorrect value");
    Environment.Exit(0);
}
for (int i=1; i<=a; i++)
    Console.WriteLine(Math.Pow(i, 3));
