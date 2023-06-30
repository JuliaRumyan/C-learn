// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 int InputNum(string message)
{
    Console.Write(message); //выводим приглашение ко вводу
    return int.Parse(Console.ReadLine()!); // приводим к числу и возвращаем результат
}

double[] CreateArray(int length, int minValue, int maxValue) // метод получения случайных значений массива - вещественных чисел
{
    double[] array = new double[length]; //Объявляем массив
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < length; i++)
    {
        // заполнение случайными числами из диапазона, 
         array[i] = rnd.Next(minValue, maxValue ++)/100.0;   
        // array[i]= InputNum($"Введите {i} элемент массива");      
    }
    return array;
}
void PrintArrayray(double[] array)
{
    Console.Write("["); // вывод скобки массива
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); // вывод значения массива
    }
    Console.Write($"{array[array.Length - 1]}]\n");
}
double MaxElement(double[] array) // задаем функцию для нахождения максимального элемента массива 
{
    double max = array[0];  
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}
double MinElement(double[] array) // задаем функцию для нахождения минимального элемента массива 
{
    double min = array[0];  
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}
double DiffMaxMin(double min, double max) // задаем функцию для нахождения разницы между макс и мин  элементами массива 
{
    return max  -min;
}
int length = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента массива: ")*100;
int maxValue = InputNum("Введите максимальное значение элемента массива: ")*100;
double[] array = CreateArray(length, minValue, maxValue); //заполнение массива случайными вещественными числами в диапазоне

PrintArrayray(array); //вывод массива

double min = MinElement(array);
double max = MaxElement(array);
double diff = DiffMaxMin(min, max);
Console.WriteLine($" Разница между максимальным и минимальным элементом массива: {max} - {min} = {diff}");





