// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Inputnum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int Ackerman(int num1, int num2) // функция Аккермана ack(n, m)
{if (num1 == 0) return num2 +1; 
//    если n = 0
//      вернуть m + 1
if (num2 ==0) return Ackerman(num1 -1,1);
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
return Ackerman(num1-1,Ackerman(num1,num2 - 1));
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
}
int num1 = Inputnum("Введите целое число M:");
int num2 = Inputnum("Введите целое число N:");
Console.Write("A(m,n)="); 
Console.WriteLine(Ackerman(num1,num2)); 