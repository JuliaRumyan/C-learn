// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 a[i] = Convert.ToDouble(Console.ReadLine());
 
int InputNum(string message)
{
    Console.Write(message); //выводим приглашение ко вводу
    return int.Parse(Console.ReadLine()!); // приводим к числу и возвращаем результат
}

double[] CreateArray(int length) // метод создания массива веществ. чисел
{
    return new double[length];
}   
    
void FillArray(double[] array) // заполняем массив
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
    {
        // заполнение случайными числами из диапазона, 
         array[i] = rnd.Next(-1500,1500)/100.0;  
    }
}
void PrintArrayray(double[] array)
{
    Console.Write("["); // вывод скобки массива
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); // вывод значения массива
    }
    Console.Write($"{array[array.Length - 1]}]\n"); // \n - это переход на новую строку 
}
double MaxElement(double[] array) // задаем функцию для нахождения максимального элемента массива 
{
    double max = array[0];  
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}
double MinElement(double[] array) // задаем функцию для нахождения минимального элемента массива 
{
    double min = array[0];  
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}
double DiffMaxMin(double min, double max) // задаем функцию для нахождения разницы между макс и мин  элементами массива 
{
    return max  -min;
}
int length = InputNum("Введите размер массива: ");
double[] array = CreateArray(length); //заполнение массива случайными вещественными числами в диапазоне
FillArray(array);
PrintArrayray(array); //вывод массива

double min = MinElement(array);
double max = MaxElement(array);
double diff = DiffMaxMin(min, max);
Console.WriteLine($" Разница между максимальным и минимальным элементом массива: {max} - {min} = {diff}");





