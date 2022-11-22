// See https://aka.ms/new-console-template for more information
    Console.WriteLine("u can write 3 int numbers");
     Console.Write("a=");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("b=");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("c=");
    int c = Convert.ToInt32(Console.ReadLine());
    
    if (a > b)
{
    if (a > c)
            Console.WriteLine("max= " + a);
}

if (b > c)
{
    if (b > a)
            Console.WriteLine("max= " + b);
}

if (c > b)
{
    if (c > a)
        Console.WriteLine("max= " + c);
}
   