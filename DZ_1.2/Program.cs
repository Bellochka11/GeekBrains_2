// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// (Цифры считать справа налево).

Console.WriteLine("Введите число: ");
int a1 = int.Parse(Console.ReadLine()!);
if (a1 > 99)
{
   int a2 = a1 % 1000;
   int a3 = a2 / 100;
    Console.WriteLine($"{a3}");
}
else Console.WriteLine("Третьей цифры нет");
