/*  Задача 1: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
Console.Clear();

int [,] CreatingArr()
{
    Console.Write("Input number of rows ");
    string text_row = Console.ReadLine();
    int row = text_row == "" ? 0 : int.Parse(text_row);

    Console.Write("Input number of columns ");
    string text_col = Console.ReadLine();
    int col = text_col == "" ? 0 : int.Parse(text_col);

    int [,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr [i, j] = new Random().Next(1, 13);
    return arr;
}

void PrintArr(int [,] arr)
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

int [,] MaxToMin(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int temp, i, j, p, max;
    for (i = 0; i < row_size; i++)
    {
        for ( j = 0; j < col_size; j++)
        {
            max = arr [i, j];
            for (p = 0; p <= j; p++)
            {
                if (max > arr [i, p])
                    (arr [i, j], arr [i, p]) = (arr [i, p], arr [i, j]);
            }
        }
    }
    return arr;
}

int[,] test1 = CreatingArr();
PrintArr(test1);
Console.WriteLine();
MaxToMin(test1);
PrintArr(test1);