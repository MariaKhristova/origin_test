//1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
Console.Write ("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.Write ($"{num1} является квадратом {num2}");
}
else Console.Write ($"{num1} не является квадратом {num2}");