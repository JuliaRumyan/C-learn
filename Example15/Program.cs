﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 6)
    Console.Write("Нет");
else
    Console.Write("Да");