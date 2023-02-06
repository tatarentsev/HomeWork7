// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int l = 3;
int k = 4;

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
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

Console.WriteLine($"Сумма первого столбца равняется: {array[0,0] + array[1,0] + array[2,0]}");
Console.WriteLine($"Сумма второго столбца равняется: {array[0,1] + array[1,1] + array[2,1]}");
Console.WriteLine($"Сумма третьего столбца равняется: {array[0,2] + array[1,2] + array[2,2]}");
Console.WriteLine($"Сумма последнего столба равняется: {array[0,3] + array[1,3] + array[2,3]}");
Console.ReadLine();