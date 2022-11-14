// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = GetRow(matrix, i);
        Array.Sort(row, (x, y) => y.CompareTo(x));
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = row[j];
        }
    }
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
SortMatrix(matrix);
PrintMatrix(matrix);