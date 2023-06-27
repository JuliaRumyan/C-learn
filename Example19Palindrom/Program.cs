// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ReverseNum(int number)
{
    int reversedNum = 0;
    while (number !=0)
    {
        reversedNum = reversedNum * 10 +number % 10;
        number /=10;
    }
    return reversedNum;
}

bool Palindrom(int num,int rev)
{
    return num == rev;
}

int num = InputNum("Введите пятизначное число: ");

if (Palindrom(num,ReverseNum(num)))
    Console.WriteLine("да");
else Console.WriteLine("нет");


