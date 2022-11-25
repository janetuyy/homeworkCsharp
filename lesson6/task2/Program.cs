// See https://aka.ms/new-console-template for more information
/* 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("let's start");
double[,] koef = new double[2,2];
for (int i=0; i<2; i++)
{
    Console.Write($"write b{i+1}=");
    koef[i,0] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"write k{i+1}=");
    koef[i,1] = Convert.ToDouble(Console.ReadLine());

}

double[] findsol(double[,] koef)
{
double x = (koef[1,0]-koef[0,0])/(koef[0,1]-koef[1,1]);
double y = x*koef[0,1]+koef[0,0];
double[] res = {x,y};
return res;
}

double[] res = findsol(koef);
Console.WriteLine($"({res[0]},{res[1]})");
