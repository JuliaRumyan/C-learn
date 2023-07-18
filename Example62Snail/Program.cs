// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("00 "));
        Console.WriteLine("");
    }

}

int[,] CreateArray(int numberRow, int numberCol)
{
    int[,] array = new int[numberRow, numberCol];
    int move = 0;
    int row = 0, col = 0, val = 1;
    while (val <= numberRow * numberCol)
    {
        array[row, col] = val++; // val =2, в массив записывается 1

        if (move == 0 && !(++col < numberCol && array[row, col] == 0)) // идет вправо
        {
            move = 1; // спуск вниз
            col--; // возвращаемся на крайнюю колонку

        }
        // идем вниз
        if (move == 1 && !(++row < numberRow && array[row, col] == 0))
        {
            move = 2; // переключаем направление влево                    
            row--;

        }
        // идем влево
        if (move == 2 && !(--col >= 0 && array[row, col] == 0))
        {
            move = 3; // переключаем на движение вверх
            col++;

        }
        // идем вверх
        if (move == 3 && !(--row >= 0 && array[row, col] == 0))
        {
            move = 0; // переключаем на движение вправо
            col++;
            row++;
        }
    }
    return array;
}

int numberRow = 4, numberCol = 4;
int[,] array = CreateArray(numberRow, numberCol);
PrintArray(array);






