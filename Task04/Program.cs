﻿// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num % num2;

if (result == 0)
{
    Console.WriteLine($"{num2} кратно {num}");
} 

else
{
    Console.WriteLine($"{num2} не кратно {num}, {result}");
}


