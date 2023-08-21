﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите координаты первой точки");

Console.Write("X:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");

Console.Write("X:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(Math.Round(dist, 2));
