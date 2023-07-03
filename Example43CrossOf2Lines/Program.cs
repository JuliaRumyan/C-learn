// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNum(string message)
{
    Console.Write(message); //выводим приглашение ко вводу
    return double.Parse(Console.ReadLine()!); // приводим к числу и возвращаем результат
}

var b1 = InputNum ("Введите число b1: ");
var b2 = InputNum ("Введите число b2: ");
var k1 = InputNum ("Введите число k1: ");
var k2 = InputNum ("Введите число k2: ");
var y = (b2*k1 - b1* k2) / (k1 - k2);
var x = (y-b1) / k1;
Console.WriteLine($"Пересечение  рямых в точке с координатами: ({x};{y})");
