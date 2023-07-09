// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = Prompt("Введите количество строк ");
int columns = Prompt("Введите количество столбцов ");
int minValue = Prompt("Введите минимальное значение элементов массива ");
int maxValue = Prompt("Введите максимальное значение элементов массива ");
int[,] arr = GenerateArray(rows, columns, minValue, maxValue);

Print2DArray(arr);
SortArr(columns, rows);
Console.WriteLine("");
Print2DArray(arr);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SortArr(int columns, int rows)
{
    int[] row = new int[columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            row[j] = arr[i, j];
        BubbleSort(row);
        Insert(true, i, row, arr);
    }
}

void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
        {
            dest[dim, k] = source[k];
        }
        else
        {
            dest[k, dim] = source[k];
        }
    }
}


int[,] GenerateArray(int row, int column, int min, int max)
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

void Print2DArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}
