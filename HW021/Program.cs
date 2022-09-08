﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве

System.Console.Write("Введите координату х первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
System.Console.Write("Введите координату y первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);
System.Console.Write("Введите координату z первой точки: ");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

System.Console.Write("Введите координату х второй точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
System.Console.Write("Введите координату y второй точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);
System.Console.Write("Введите координату z второй точки: ");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberX_1 || !isNumberX_2 || !isNumberY_1 || !isNumberY_2 || !isNumberZ_1 || !isNumberZ_2)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

System.Console.Write($"Растояние: {GetLenght(x1,y1,z1,x2,y2,z2)}");

double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));
}
