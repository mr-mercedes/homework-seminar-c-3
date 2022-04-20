﻿Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.");
double x1 = Coordinate("x", "A");
double y1 = Coordinate("y", "A");
double z1 = Coordinate("z", "A");
double x2 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");
double z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Quarter(double x)
{
    return x * x; 
}

double result = Math.Sqrt(Quarter(x2 - x1) + Quarter(y2 - y1) + Quarter(z2 - z1));

Console.WriteLine($"Расстояние между точками {Math.Round(result, 2)}");