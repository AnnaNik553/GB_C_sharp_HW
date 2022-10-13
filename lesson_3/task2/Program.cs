// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


(int, int, int) GetCoordinates(string str)
{
    string[] coords = str.Split(new string[] { "," }, StringSplitOptions.None);
    return (int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
}

double GetDistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine("Введите координаты перой точки через запятую (пример: 3,6,8):");
(int x1, int y1, int z1) = GetCoordinates(Console.ReadLine() ?? "");
Console.WriteLine("Введите координаты второй точки через запятую (пример: 3,6,8):");
(int x2, int y2, int z2) = GetCoordinates(Console.ReadLine() ?? "");
Console.WriteLine(GetDistanceBetweenPoints(x1, y1, z1, x2, y2, z2));