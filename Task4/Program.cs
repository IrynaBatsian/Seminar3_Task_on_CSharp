// Задача №22. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
double i = 1;
while ( i <= n)
{
  Console.Write($"{Math.Pow(i,2)}, ");
  i++;
}
