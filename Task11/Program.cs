// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int i = 0;

while (num > 0)
{
    i++;
    num /= 10;
}

Console.WriteLine("Количество цифр введённого числа: {0}", i);

// Второе решение

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num = Math.Abs(num);

// int Count(int number)
// {
//     int result = 0;
//     if (number >= 0 && number < 10) result = 1;
//     else
//         result = 0;
//     {
//         while (number > 0)
//         {
//             result++;
//             number = number / 10;
//         }
//     }
//     return result;
// }
// int countNum = Count(num);
// Console.WriteLine($"Количество цифр в числе {num} = {countNum}");

// Третье решение

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());

// int count = 0;

// while (a != 0)
// {
//     a = a / 10;
//     count++;
// }
// Console.WriteLine(count);