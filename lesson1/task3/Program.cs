// See https://aka.ms/new-console-template for more information
Console.WriteLine("write a int");
Console.Write("a=");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("yes");
}
if (a%2!=0)
{
    Console.WriteLine("no");
}
