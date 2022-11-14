// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix(int m = 3, int n = 4)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowMinSum(int[,] matrix)
{
    int numRow = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = GetRow(matrix, i);
        int sum = row.Sum();
        if (i == 0)
        {
            minSum = sum;
        }
        if (sum < minSum)
        {
            minSum = sum;
            numRow += 1;
        }
    }

    return numRow + 1;
}

int[] GetRow(int[,] matrix, int rowNumber)
{
    return Enumerable.Range(0, matrix.GetLength(1))
            .Select(x => matrix[rowNumber, x])
            .ToArray();
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"{GetRowMinSum(matrix)} строка имеет наименьшую сумму элементов");
