// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

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
void ElementOnPozition(int[,] array, int elementCol, int elementRow)
{
    if (array.GetLength(0) <  elementRow || array.GetLength(1) <  elementCol) Console.WriteLine(" Такого элемента нет");
    else Console. WriteLine($"На данной позиции находится число {array[elementRow-1,elementCol-1]}");
}

int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int elementRow = InputNum("Укажите номер строки: ");
int elementCol = InputNum("Укажите номер столбца: ");
int[,] myArray = new int[5, 6];
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
ElementOnPozition(myArray, elementCol,  elementRow);