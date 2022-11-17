// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }

    // если значения введены некорректно: начальное больше конечного
    if (m > n)
    {
        return n + GetSum(n + 1, m);
    }

    return m + GetSum(m + 1, n);
}

Console.WriteLine("Введите начальное значение M:");
int M = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите конечное значение N:");
int N = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine(GetSum(M, N));
