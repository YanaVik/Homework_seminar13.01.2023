// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
Console.WriteLine("Второе число больше первого");

if (b < max)
Console.WriteLine("Первое число больше второго");