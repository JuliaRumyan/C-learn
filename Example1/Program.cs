﻿// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Очевидно, что их значения будут равны. Тогда зачем их сравнивать?)
// Достаточно просто организовать неполное ветвление из одного блока if, где Вы сравниваете max и num2Очевидно, что их значения
//  будут равны. Тогда зачем их сравнивать?)
// Достаточно просто организовать неполное ветвление из одного блока if, где Вы сравниваете max и num2

Console.WriteLine("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine()!);
int max = num1;
if (num2 > max)
    max = num2;
Console.Write($"Больше число: {max}");


