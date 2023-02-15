// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

//d = √ (х А – х В) 2 + (у А – у В) 2
// Math.Sqrt(); - находит квадратный корень числа
// Math.Pow(a,2) - возводит число в степень
// Math.Round(); - округляет число

Console.WriteLine("Введите координату x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine()!);
double d = Math.Sqrt((Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2))); //d = √ (х А – х В) 2 + (у А – у В) 2
// d = Math.Round(d,2);                                      // округление либо так
Console.WriteLine($"Расстояние между точками равно: {d:F3} "); // либо через {d:F3} 3 знака после запятой
