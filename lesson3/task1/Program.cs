// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Hello, write 5 char num");
string a=Console.ReadLine();
if (a.Length!=5)
    Console.WriteLine("eror: incorrect value");
else
    if (a[1]==a[3] && a[0]==a[4])
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");