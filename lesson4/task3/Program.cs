// See https://aka.ms/new-console-template for more information
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("tell me ur numbers");
int[] num()
{
    int[] numbers = new int[8];
    for (int i = 0; i < 8; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());

    }

    return numbers;
}
int[] array = num();
string s = "";
foreach (double item in array)
{
    s += $"{item}, ";
}
s = s.TrimEnd(' ');
s = s.TrimEnd(',');
Console.WriteLine($"[{s}]");