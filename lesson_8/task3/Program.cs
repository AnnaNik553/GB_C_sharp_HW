// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя умножить");
        return null;
    }
    int[,] matrix = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = GetRow(A, i);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int[] column = GetColumn(B, j);
            int[] arr = new int[column.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = row[k] * column[k];
            }
            matrix[i, j] = arr.Sum();
        }
    }

    return matrix;
}

int[] GetRow(int[,] matrix, int rowNumber)
{
    return Enumerable.Range(0, matrix.GetLength(1))
            .Select(x => matrix[rowNumber, x])
            .ToArray();
}

int[] GetColumn(int[,] matrix, int columnNumber)
{
    return Enumerable.Range(0, matrix.GetLength(0))
            .Select(x => matrix[x, columnNumber])
            .ToArray();
}

int[,] matrixA = InitMatrix(3, 2);
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = InitMatrix(2, 2);
PrintMatrix(matrixB);
Console.WriteLine();

int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
if (matrixC != null)
{
    PrintMatrix(matrixC);
}
