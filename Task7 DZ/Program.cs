// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("{0} max", a);
}
if (c > b && c > a)
{
    Console.WriteLine("{0} max", c);
}
if (b > c && b > a)
{
    Console.WriteLine("{0} max", b);
}