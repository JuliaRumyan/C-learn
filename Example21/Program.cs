// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату xa ");
double xa = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату ya ");
double ya = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату za ");
double za = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату xb ");
double xb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату yb ");
double yb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату zb ");
double zb = double.Parse(Console.ReadLine()!);

double dist = Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2) + Math.Pow(za-zb,2));
Console.WriteLine(dist);

