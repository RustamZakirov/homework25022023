// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n, int count)
{
    if (m > n)
        return count;
    return Sum(m + 1, n, count + m);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine($"Сумма чисел от M до N: {Sum(m, n, count)}");