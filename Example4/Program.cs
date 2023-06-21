// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число N: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"{num} -> ");
for (int i = 1; i <= num; i++)
{
    if (i%2 == 0 && (i+1) < num )
        Console.Write($"{i},");
    if (i%2 == 0 && (i+1) >= num )
        Console.Write($"{i}");
}
