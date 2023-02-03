// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int firstMatrixRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы: ");
int firstMatrixColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int secondMatrixRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы: ");
int secondMatrixColumns = Convert.ToInt32(Console.ReadLine());

if (firstMatrixColumns != secondMatrixRow)
    Console.WriteLine("Умножение матриц невозможно, так как число столбцов первой матрицы не равно числу строк второй матрицы! ");

else
{
    int[,] firstArray2D = CreateMatrixRndInt(firstMatrixRow, firstMatrixRow, 1, 10);
    PrintMatrix(firstArray2D);
    Console.WriteLine();

    int[,] secondArray2D = CreateMatrixRndInt(secondMatrixRow, secondMatrixColumns, 1, 10);
    PrintMatrix(secondArray2D);
    Console.WriteLine();

    int[,] multiplyArray = MatrixMultiplication(firstArray2D, secondArray2D);
    PrintMatrix(multiplyArray);
}