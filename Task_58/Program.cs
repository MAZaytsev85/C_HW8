// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = 2;
int columns = 2;
int minValue = 1;
int maxValue = 10;
int[,] arr1 = GetArray(rows, columns, minValue, maxValue);
int[,] arr2 = GetArray(rows, columns, minValue, maxValue);

PrintArr(arr1);
Console.WriteLine();
PrintArr(arr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
Console.WriteLine();
Multiplication(arr1, arr2);

int[,] GetArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    else
    {
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i, j] += a[i, k] * b[k, j];
                }
                Console.Write($"{r[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

