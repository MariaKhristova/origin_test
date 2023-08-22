// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
void Array(int[] collection)
{
    int i = 0;
    while(i < collection.Length)
    {
        collection[i] = new Random().Next(0, 2);
        i++;
    }
}

void Print(int[] collection)
{
    int i = 0;
    Console.Write("[");
    while(i < collection.Length)
    {
        Console.Write($"{collection[i]}, ");
        i++;
    }
     Console.Write("]");
}

Array(array);
Print(array);