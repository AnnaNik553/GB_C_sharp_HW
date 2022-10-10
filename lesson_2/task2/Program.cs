// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void GetThirdDigit(int num)
{
    num = Math.Abs(num);
    if (num.ToString().Length <= 2)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        double x = num.ToString().Length - 3;
        double y = 10;
        Console.WriteLine($"{Math.Truncate(num / Math.Pow(y, x) % 10)}");
    }
}

Console.WriteLine("Введите число:");
GetThirdDigit(int.Parse(Console.ReadLine() ?? ""));
