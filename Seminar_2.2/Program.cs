// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите четверть");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
    Console.WriteLine("x > 0 y > 0");
}
if (x == 2)
{
    Console.WriteLine("x < 0 y > 0");
}
if (x == 3)
{
    Console.WriteLine("x < 0 y < 0");
}
if (x == 4)
{
    Console.WriteLine("x > 0 y < 0");
}
// вариант через свитч кейс 
// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine()!);

// switch (quarter)
// {
// case 1:
// {
// Console.WriteLine("x>0 y>0");
// break;
// }
// case 2:
// {
// Console.WriteLine("x<0 y>0");
// break;
// }
// case 3:
// {
// Console.WriteLine("x<0 y<0");
// break;
// }
// case 4:
// {
// Console.WriteLine("x>0 y<0");
// break;
// }

// default:
// {
// Console.WriteLine("Введена неправильная четверть");
// break;
// }
}