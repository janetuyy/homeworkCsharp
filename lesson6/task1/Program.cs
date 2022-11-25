// See https://aka.ms/new-console-template for more information
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Hey, how many num will u write to me?");
int res = 0;
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Hey, write ur numbers");

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        res += 1;
    }
}
Console.WriteLine(res);