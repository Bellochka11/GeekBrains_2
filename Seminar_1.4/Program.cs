﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет  46 -> нет  161 -> да
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 7;
int c = a % 23;
if (b == 0 && c == 0)
{
    Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
}
else

Console.WriteLine($"Число {a} не кратно одновременно 7 и 23");
