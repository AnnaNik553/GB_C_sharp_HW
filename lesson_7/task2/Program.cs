// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// если я правильно поняла задание, потому что тестовые данные вводят в заблуждение (17 -> такого числа в массиве нет)
// нужно найти и вернуть элемент по его позиции в массиве, если такой позиции нет, то вернуть "такого числа в массиве нет"


int[,] InitMatrix(int m = 3, int n = 4)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(-10, 10);
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

void GetElementInArray(int m, int n, int[,] matrix)
{
    if (m < 0 || m >= matrix.GetLength(0) || n < 0 || n >= matrix.GetLength(1))
        Console.WriteLine("такого числа в массиве нет");
    else
        Console.WriteLine(matrix[m, n]);
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);

Console.WriteLine("Введите номер строки:");
int idxStr = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите позицию элемента в строке:");
int idxCol = int.Parse(Console.ReadLine() ?? "");
GetElementInArray(idxStr, idxCol, matrix);