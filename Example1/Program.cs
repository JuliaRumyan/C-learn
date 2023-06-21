// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine());
int max=num1;
if (num1>max)
    max=num1;
else
     max=num2;
Console.Write ($"Больше число: {max}");


