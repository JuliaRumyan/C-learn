// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckValue(int[,,] array,  int value)
{
     for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (value == array[i, j, k])
                    return true;
    return false;
}
void Fill3DArray(int[,,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int temp = rnd.Next(min, max + 1);
                while (CheckValue(array,  temp))
                    temp = rnd.Next(min, max + 1);
                array[i, j, k] = temp;
            }
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[j, k, i]} ({j},{k},{i})\t");
            Console.WriteLine("");
        }
    }
}
int[,,] myArray = new int[2, 2, 2];
Fill3DArray(myArray, 10, 99);
Print3DArray(myArray);



