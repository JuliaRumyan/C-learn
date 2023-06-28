//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    Console.Write($"{array[array.Length - 1]}]"); // вывод последнего элемента и закрывающей скобки, -1 так как индексы с нуля
}
int SumOfOddElements(int[] array) // задаем функцию для подсчета суммы нечетных элементов массива
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
        sum = sum + array[i]; 
    return sum;
}
int length = InputNum("Введите размер массива: ");
int minValue = 10;
int maxValue = 99;
int[] array = CreateArray(length, minValue, maxValue); //заполнение массива случайными трехзначными числами в диапазоне
PrintArrayray(array); //вывод массива
int sum = SumOfOddElements(array);
Console.WriteLine($" Сумма нечетных элементов массива равна {sum}");





