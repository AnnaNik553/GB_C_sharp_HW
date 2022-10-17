// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void GetSumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");

GetSumDigits(num);