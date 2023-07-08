// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//     1 4 7 2
//     5 9 2 3
//     8 4 2 4
//     5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArrD2(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(1, 9);
        }
    }
    return arrayD2;
}

void ShowArrayD2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}
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

void SummaRows(int[,] arr)
{
    int sumfistRow = arr[0, 0];
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        sumfistRow += arr[0, k];
    }
    int count = 0;
    int sumMin = sumfistRow;  //если здесь присвоить сумму которой в массиве не встретиться(большую цифру) то переменную sumfistRow и цикл можно удалить
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = arr[0, 0];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            count = i;

        }
    }
    System.Console.WriteLine($"номер строки с наименьшей суммой элементов:{count + 1}");


}
int cols = ReadInt("Введите количество столбцов");
int rows = cols + 3;
int[,] array = CreateArrD2(rows, cols);

ShowArrayD2(array);
System.Console.WriteLine();

SummaRows(array);