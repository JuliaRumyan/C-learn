//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9 
int InputNum0(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }
void Fill2DArray(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min*100, (max + 1)*100)/100.0;
}
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            // при выводе \t используется для выравнивания - на каждое значение 8 символов = табуляция   
            Console.Write($"{array[i, j]}\t");   
        Console.WriteLine();
    }
}
int rows = InputNum0("Введите количество строк: ");
int columns = InputNum0("Введите количество столбцов: ");
int minValue = InputNum0("Введите минимальное значение диапазона: ");
int maxValue = InputNum0("Введите максимальное значение диапазона: ");

double[,] myArray = new double[rows, columns];
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);

