// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
FillArrayMidle(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void FillArrayMidle(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.WriteLine($"Средее арифметическое элементов в столбце {j}: {sum/matr.GetLength(0)}");
    }
}
