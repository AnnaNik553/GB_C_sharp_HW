// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
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

float[] GetAverageInColumn(int[,] matrix)
{
    float[] result = new float[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        float avg = (float)Math.Round(sum / (float)matrix.GetLength(0), 1);
        result[j] = avg;
    }

    return result;
}


int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine(string.Join("; ", GetAverageInColumn(matrix)));