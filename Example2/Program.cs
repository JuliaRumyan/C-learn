//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int num3 = int.Parse(Console.ReadLine());
int max=num1;
if (num1>max)
    max=num1;
if (num2>max)   
    max=num2;
else
    max=num3;
Console.Write ($"Больше число: {max}");



