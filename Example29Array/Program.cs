// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array)
{
    for (int i = 0; i <= 7; i++)
        array[i] = new Random().Next(-10, 10);
}

void PrintArray(int[] array)
{
    for (int i = 0; i <= 7; i++)
        Console.Write($"{array[i]} ");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);


