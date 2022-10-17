// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]
// ввод элеменетов через консоль (через запятую. использовать метод string.Split())


void PrintArray(string str)
{
    string[] arr = str.Split(new string[] { "," }, StringSplitOptions.TrimEntries);
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

Console.WriteLine("Введите элементы массива через запятую: ");
PrintArray(Console.ReadLine() ?? "");
