// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] InitMatrix(int m = 4, int n = 4)
{
    int[,] resultMatrix = new int[m, n];
    int r = 0;
    int c = 0;
    int startRow = 0;
    int startColumn = 0;
    int endRow = m - 1;
    int endCol = n - 1;

    int value = 1;

    while (value < m * n)
    {
        //вправо
        while (c < endCol)
        {
            resultMatrix[r, c] = value;
            value++;
            c++;
        }

        // вниз
        while (r < endRow)
        {
            resultMatrix[r, c] = value;
            value++;
            r++;
        }
        endCol--;
        endRow--;

        // влево
        while (c > startColumn)
        {
            resultMatrix[r, c] = value;
            value++;
            c--;
        }

        //вверх
        while (r > startRow)
        {
            resultMatrix[r, c] = value;
            value++;
            r--;
        }
        r++;
        c++;
        startRow++;
        startColumn++;
    }

    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (resultMatrix[r, c] == 0)
            {
                resultMatrix[r, c] = value;
            }
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
            Console.Write($"{matrix[i, j].ToString("D2")} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
