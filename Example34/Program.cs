// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message); //выводим приглашение ко вводу
    return int.Parse(Console.ReadLine()!); // приводим к числу и возвращаем результат
}

int[] CreateArray(int Length, int minValue, int maxValue) // метод для получения случайных значений массива
{
    int[] array = new int[Length]; //Объявляем массив
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1); // заполнение случайными числами из диапазона, +1 так как последнее значение не включается [)
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
    Console.Write($"{array[array.Length - 1]}"); // вывод значения массива без запятой
    Console.Write("]"); // вывод скобки массива
}
int NumofEvenNumbers(int[] array) // задаем функцию для подсчета четных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            sum++;
    return sum;
}
int Length = InputNum("Введите размер массива: ");
int minValue = 100;
int maxValue = 999;
int[] array = CreateArray(Length, minValue, maxValue); //заполнение массива случайными трехзначными числами в диапазоне
PrintArrayray(array); //вывод массива
int sum = NumofEvenNumbers(array);
Console.WriteLine($" Количество четных чисел в массиве равно {sum}");





