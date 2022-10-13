// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumberInPower(int x, int y)
{
    int result = x;
    for (int i = 1; i < y; i++)
    {
        result *= x;
    }
    return result;
}

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine(GetNumberInPower(A, B));
