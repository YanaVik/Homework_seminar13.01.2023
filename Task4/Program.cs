// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 0;
Console.WriteLine("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (i < N)

{
    i +=2;
    Console.Write(i);
}