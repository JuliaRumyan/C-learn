// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите целое число N");
Console.WriteLine($"Таблица кубов чисел от 1 до N");

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i < num)
        Console.Write(",");
    else
        Console.Write(" ");
}


