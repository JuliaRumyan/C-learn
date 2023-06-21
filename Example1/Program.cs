// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);
Console.WriteLine("Введите второе целое число: ");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);
int max=num1;
if (num1>max) max=num1;
if (num2>max) max=num2;
Console.Write ("Больше число:  ");
Console.WriteLine (max);

