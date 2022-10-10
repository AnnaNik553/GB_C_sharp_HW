// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void GetSecondDigit(int num)
{
    Console.WriteLine($"{num / 10 % 10}");
}

Console.WriteLine("Введите трехзначное число:");
GetSecondDigit(int.Parse(Console.ReadLine() ?? ""));