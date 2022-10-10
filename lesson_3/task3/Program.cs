// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double[] GetTableOfCubes(int n)
{
    double[] result = new double[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Math.Pow(i + 1, 3);
    }
    return result;
}

Console.WriteLine("Введите число: ");
Console.WriteLine("{0}", string.Join(", ", GetTableOfCubes(int.Parse(Console.ReadLine() ?? ""))));