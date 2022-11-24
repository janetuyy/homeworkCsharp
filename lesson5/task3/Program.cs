// See https://aka.ms/new-console-template for more information
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Hello, World!");
string n = "";
float[] array = new float[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Convert.ToSingle(Console.ReadLine());
}
float max = array.Max();
float min = array.Min();

Console.WriteLine(max - min);