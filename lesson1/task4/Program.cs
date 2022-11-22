// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, write an int !");
int a=Convert.ToInt32(Console.ReadLine());
string s="";
for (int i = 1; i <= a; i++)
    if (i%2==0)
        s+=$"{i},";
s=s.TrimEnd(' ');
s=s.TrimEnd(',');
Console.WriteLine(s);