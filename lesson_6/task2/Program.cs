// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


(double, double) GetIntersectionPoint(string coords)
{
    double x = 0;
    double y = 0;

    string[] strings = coords.Split(new string[] { "," }, StringSplitOptions.TrimEntries);
    double[] floats = Array.ConvertAll(strings, double.Parse);
    double b1 = floats[0];
    double k1 = floats[1];
    double b2 = floats[2];
    double k2 = floats[3];

    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        x = Math.Round((b2 - b1) / (k1 - k2), 2);
        y = Math.Round((k1 * (b2 - b1)) / (k1 - k2) + b1, 2);
    }
    return (x, y);
}


Console.WriteLine("Введите значения b1, k1, b2 и k2 через запятую: ");
string coords = Console.ReadLine() ?? "";
Console.WriteLine(GetIntersectionPoint(coords));
