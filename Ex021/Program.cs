﻿// Программа, которая принимает на вход координаты двух точек и находит растояние между ними в 2D пространстве.
System.Console.Write("Введите координату х первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
System.Console.Write("Введите координату y первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);

System.Console.Write("Введите координату х первой точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
System.Console.Write("Введите координату y первой точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);

if(!isNumberX_1 || !isNumberX_2 || !isNumberY_1 || !isNumberY_2)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

System.Console.Write($"Растояние: {GetLenght(x1,y1,x2,y2)}");

double GetLenght(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}