// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void GetNumberGreaterZero(string value)
{
    int count = 0;
    string[] strings = value.Split(new string[] { "," }, StringSplitOptions.TrimEntries);
    int[] ints = Array.ConvertAll(strings, int.Parse);

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > 0)
        {
            count += 1;
        }
    }
    Console.Write(count);
}

Console.WriteLine("Введите элементы массива через запятую: ");
GetNumberGreaterZero(Console.ReadLine() ?? "");