// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message) // создаем функцию для ввода
{
    Console.WriteLine(message); // выводим приглашение ко вводу
    int num = int.Parse(Console.ReadLine()!); // приводим к числу введенное значение
    return num; // возвращаем результат
}

int num1 = InputNum("Введите целое число A");
int num2 = InputNum("Введите степень числа А");

Console.Write($"Число А в степени : {Math.Pow(num1, num2)}");

    