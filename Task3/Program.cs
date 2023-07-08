// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] arr)
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

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}


int rowsMatrix1 = ReadInt("Введите количество строк 1 массива: ");
int columnsMatrix1 = ReadInt("Введите количество столбцов 1 массива: ");
int rowsMatrix2 = columnsMatrix1;
int columnsMatrix2 = ReadInt("Введите количество столбцов 2 массива: ");

if (columnsMatrix1 != rowsMatrix2)
{
    Console.WriteLine("Количество колонок первый матрицы должно совподать с количеством строк второй матрицы!");
    return;
}

int[,] matrix1 = new int[rowsMatrix1, columnsMatrix1];
CreateRandomArray(matrix1);
Console.WriteLine($"Первая матрица:");
ShowArray(matrix1);

int[,] matrix2 = new int[rowsMatrix2, columnsMatrix2];
CreateRandomArray(matrix2);
Console.WriteLine($"Вторая матрица:");
ShowArray(matrix2);

int[,] resultMatrix = new int[rowsMatrix1, columnsMatrix2];

MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
ShowArray(resultMatrix);