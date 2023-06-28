// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Один из наиболее простых способов найти сумму цифр в числе заключается в использовании цикла и операции взятия остатка от деления. Идея 
// заключается в том, чтобы последовательно извлекать цифры из числа путем нахождения остатка от деления на 10 и добавлять их в сумму.

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SumofFigures(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
int num = InputNum("Введите целое число:");
int sum = SumofFigures(num);

Console.Write($"Сумма цифр в числе равна: {sum}");