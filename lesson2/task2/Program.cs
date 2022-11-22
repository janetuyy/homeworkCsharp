// See https://aka.ms/new-console-template for more information
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Hello, write num!");
//int a=0;
//a=Convert.ToInt32(Console.ReadLine());
string s=Console.ReadLine();
if (s.Length<3)
    Console.WriteLine("nothing to see here");
else
    Console.WriteLine(s[2]);