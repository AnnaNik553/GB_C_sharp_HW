// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void GetDayOff(int num)
{
    if (num > 7 || num < 1)
    {
        Console.WriteLine("такого дня недели нет");
    }
    else
    {
        string ans = num > 5 ? "да" : "нет";
        Console.WriteLine(ans);
    }
}

Console.WriteLine("Введите число:");
GetDayOff(int.Parse(Console.ReadLine() ?? ""));
