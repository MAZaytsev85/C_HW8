// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = Prompt("Введите количество строк ");
int columns = Prompt("Введите количество столбцов ");
int minValue = Prompt("Введите минимальное значение элементов массива ");
int maxValue = Prompt("Введите максимальное значение элементов массива ");
int[,] arr = GetArray(rows, columns, minValue, maxValue);

PrintArr(arr);
Console.WriteLine();
ResultSum(arr);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

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

int SumRows(int[,] arr, int i)
{
    int sum = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    return sum;
}

void ResultSum(int[,] arr)
{
    int minSum = 1;
    int sum = SumRows(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (sum > SumRows(arr, i))
        {
            sum = SumRows(arr, i);
            minSum = i + 1;
        }
    }
    Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
}
