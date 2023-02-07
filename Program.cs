//52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите размер m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n:  ");
int n = Convert.ToInt32(Console.ReadLine());
double sum = 0.0; 
int count = 0;




int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}



for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }






    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+=arr[j, i];
            count++;
        }
        Console.Write(Math.Round(sum/count,2));
        sum =0.0;
        count = 0;
        Console.WriteLine();
    }