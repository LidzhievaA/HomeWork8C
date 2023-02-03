// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] RowElemSum(int[,] matrix)
{
    int[] elemSum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            elemSum[i] += matrix[i, j];
        }
    }
    return elemSum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],5}");
    }
    Console.WriteLine("]");
}

int MinSumRow(int[] arr)
{
    int minElem = arr[0];
    int minSumRowNum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElem)
            minElem = arr[i];
        minSumRowNum = i;
    }
    return minSumRowNum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

int[] rowElemSum = RowElemSum(array2D);
PrintArray(rowElemSum);

int minSumRow = MinSumRow(rowElemSum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow} строка");

