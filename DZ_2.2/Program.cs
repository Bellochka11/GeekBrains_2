// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int c = 1;
int b = 2;
Console.Write($"{c}"); //выводим в консоль 1, чтобы не было лишней запятой
while (b<=a)
{
    double result = Math.Pow(b,3);
    Console.Write($", {result}");
    b++;
}