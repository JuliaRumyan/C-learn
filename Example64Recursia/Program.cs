// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Inputnum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void PrintNumbers(int start, int end)
{
    if (start == end) return;
    Console.Write(start + " ");
    PrintNumbers(--start, end);
}

int num = Inputnum("Введите целое число:");
PrintNumbers(num, 0);