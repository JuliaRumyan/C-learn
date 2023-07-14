// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void DescendingOrder(int[,] array) // функция для упорядочивания элементов строки массива по убыванию (пузырьковая сортировка)
{
    for (int i = 0; i < array.GetLength(0); i++) // проходим по строкам

        for (int j = 0; j < (array.GetLength(1) - 1); j++) // проходим по столбцам
        
            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j + 1]; // меняем элементы местами с помощью временной переменной
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
                DescendingOrder(array); //рекурсия
            }
}

int[,] myArray = new int[5, 4]; // 5 строк, 4 столбца
Fill2DArray(myArray, 1, 9); // задали сразу минимальное и макс значение 
Print2DArray(myArray);
Console.WriteLine("Отсортированный массив");
DescendingOrder(myArray);
Print2DArray(myArray);

