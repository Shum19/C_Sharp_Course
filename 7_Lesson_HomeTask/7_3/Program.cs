/*  Задача 3: Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив: 
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
int [,] CreatingArr(int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr [i, j] = new Random().Next(0, 11);
    return arr;
}

void Print (int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr [i, j], 4}");
        Console.WriteLine();
    }
}

void FindColumnAverage(int [,] arr)
{
    int col_size = arr.GetLength(1);
    int row_size = arr.GetLength(0);
    double averageOfColumn = 0;
    for (int j = 0; j < col_size; j++)
    {   averageOfColumn = 0;
        for (int i = 0; i < row_size; i++)
        {
           averageOfColumn += arr [i, j]; 
        }
        averageOfColumn /= row_size;
        averageOfColumn = Math.Round(averageOfColumn, 1);
        Console.WriteLine($"Averege of column {j+1} = {averageOfColumn}");
    }
}

Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
Print(test);
FindColumnAverage(test);
