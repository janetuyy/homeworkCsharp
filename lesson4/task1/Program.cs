// See https://aka.ms/new-console-template for more information
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int solution(int a, int b)
{
    int sol=1;
    for (int i = 0; i < b; i++)
    {
        sol*=a;
    }
    return sol;
}
Console.WriteLine("Hello, write to me two numbers");
Console.Write("A=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B=");
int b = Convert.ToInt32(Console.ReadLine());
int res=solution(a, b);
Console.WriteLine(res);

