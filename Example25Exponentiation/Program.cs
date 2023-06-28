// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num1 = InputNum("Введите целое число A");
int num2 = InputNum("Введите степень числа А");

Console.Write($"Число А в степени В: {Math.Pow(num1, num2)}");

    