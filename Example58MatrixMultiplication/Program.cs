// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr1 = { { 2, 4 }, { 3, 2 } };
int[,] arr2 = { { 3, 4 }, { 3, 3 } };

int[,] resArray(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[2, 2];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }

    return result;
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

int[,] arr = resArray(arr1, arr2);
Print2DArray(arr);

