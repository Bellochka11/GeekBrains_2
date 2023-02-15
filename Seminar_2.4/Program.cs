// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;                           //счетчик
while (count <= number)
{
   double result = Math.Pow(count,2);
   Console.Write($"{result} ");
   count++;
}
