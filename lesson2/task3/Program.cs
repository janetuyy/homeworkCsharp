// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Hello, what day of the week in num?");
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
if (1 <= a && a <= 7)
    switch (a)
    {
        case 6:
            {
                Console.WriteLine("yes");
                break;
            }
        case 7:
            {
                Console.WriteLine("yes");
                break;
            }
        default:
            {
                Console.WriteLine("no");
                break;
            }
    }
else
    Console.WriteLine("error: incorrect value");
