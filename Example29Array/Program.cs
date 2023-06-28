// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array) // метод для получения случайных значений массива
{
    for (int i = 0; i <= 7; i++)
        array[i] = new Random().Next(-10, 10);
}

void PrintArray(int[] array)
{
    Console.Write("["); // вывод скобки массива
    for (int i = 0; i <= 7; i++)
    {
        Console.Write($"{array[i]}, "); // вывод значения массива
    }
    Console.Write($"{array[7]}"); // вывод значения массива без запятой
    Console.Write("]"); // вывод скобки массива
}
int[] array = new int[8];
FillArray(array);// заполнение массива случайными числами
PrintArray(array); // вывод массива

// можно сократить так:
// int[] array = {1,2,3,4,5};
// Console.WriteLine($"[{string.Join(", ",array)}]");