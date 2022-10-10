// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindrome(int num)
{
    string str = num.ToString();


    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    string rev_str = new String(arr);

    string ans = str == rev_str ? "да" : "нет";
    Console.WriteLine(ans);
}

Console.WriteLine("Введите пятизначное число:");
IsPalindrome(int.Parse(Console.ReadLine() ?? ""));