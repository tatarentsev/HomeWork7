// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

int l = 4;
int k = 3;

int[,] array = new int[l, k];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте координату n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату m: ");
int m = Convert.ToInt32(Console.ReadLine());


if (n < l & m < k)
{
    Console.WriteLine(array[n, m]);
}

else
{
    Console.WriteLine("такого числа в массиве нет");
}

PrintArray(array);
Console.ReadLine();