// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitMatrix(int y = 2, int x = 2, int z = 2)
{
    int[,,] resultMatrix = new int[y, x, z];
    var randomNumbers = Enumerable.Range(10, 90).OrderBy(x => new Random().Next()).ToArray();
    int idx = 0;

    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < z; k++)
            {
                resultMatrix[i, j, k] = randomNumbers[idx];
                idx++;
            }
        }
    }

    return resultMatrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = InitMatrix();
PrintMatrix(matrix);
