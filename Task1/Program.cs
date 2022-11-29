// Задача №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти (1,2,3 или 4): ");
double n = Convert.ToDouble(Console.ReadLine());
if (n == 1)
    Console.Write("Возможные координаты точек x > 0 и y > 0");
else if (n == 2)
    Console.Write("Возможные координаты точек x > 0 и y < 0");
else if (n == 3)
    Console.Write("Возможные координаты точек x < 0 и y < 0");   
else if (n == 4)
    Console.Write("Возможные координаты точек x < 0 и y > 0");  
else 
    Console.Write("Неверно введен номер четверти!");   

