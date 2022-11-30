// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.Write("Введите координату точки x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 -y2,2)));

