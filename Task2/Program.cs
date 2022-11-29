// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем  X не = 0 и Y не = 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Введите координаты X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
    Console.Write("Точка находится в первой четверти");
else if (x > 0 && y < 0)
    Console.Write("Точка находится во второй четверти");
else if (x < 0 && y < 0)
    Console.Write("Точка находится в третьей четверти");
else if (x < 0 && y > 0)
    Console.Write("Точка находится в четвертой четверти");
else
    Console.Write("Данные введены неверно!");   