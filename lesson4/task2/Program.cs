// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum(int a)
{
    int s=0;
    while (a>0)
        {
            s+=a%10;
            a/=10;
        }
        return s;
}
Console.WriteLine("Hello, write me ur num!");
Console.Write("a=");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(a));
