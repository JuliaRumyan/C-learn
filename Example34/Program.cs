// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message); //выводим приглашение ко вводу
    return int.Parse(Console.ReadLine()!); // приводим к числу и возвращаем результат
}

int[] CreateArray(int length, int minValue, int maxValue) // метод для получения случайных значений массива
{
    int[] array = new int[length]; //Объявляем массив
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < length; i++)
    {
        // заполнение случайными числами из диапазона, ++ (или +1) так как последнее значение не включается [)
        array[i] = rnd.Next(minValue, maxValue ++); 
    }
    return array;
}
void PrintArrayray(int[] array)
{
    Console.Write("["); // вывод скобки массива
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); // вывод значения массива
    }
    Console.Write($"{array[array.Length - 1]}]");
}
int NumOfEvenNumbers(int[] array) // задаем функцию для подсчета четных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            sum++;
    return sum;
}
int length = InputNum("Введите размер массива: ");
int minValue = 100;
int maxValue = 999;
int[] array = CreateArray(length, minValue, maxValue); //заполнение массива случайными трехзначными числами в диапазоне
PrintArrayray(array); //вывод массива
int sum = NumOfEvenNumbers(array);
Console.WriteLine($" Количество четных чисел в массиве равно {sum}");





