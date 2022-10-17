// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

double GetDiffBetweenMaxMinElements(double[] arr)
{
    double diff = arr.Max() - arr.Min();
    return diff;
}

double[] array = GetArray(5);
PrintArray(array);
Console.WriteLine(GetDiffBetweenMaxMinElements(array));