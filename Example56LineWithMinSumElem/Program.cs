// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void LineWithMinSumm(int[,] array)
{
    int lineNumber = 0;
    int minSumLine = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumLine += array[i, j];
        if (minSumLine > sumLine)
        {
            minSumLine = sumLine;
            lineNumber = i;
        }
    }
    Console.WriteLine($"Строка  {lineNumber + 1} с минимальной суммой элементов {minSumLine}");
}

int[,] myArray = new int[4, 5];
Fill2DArray(myArray, 0, 10);
Print2DArray(myArray);
Console.WriteLine();
LineWithMinSumm(myArray);
