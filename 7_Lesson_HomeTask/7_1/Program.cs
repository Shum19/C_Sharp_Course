/*  Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5  7   -2   -0,2
    1   -3,3  8   -9,9 
    8    7,8 -7,1  9
*/
Console.Clear();
double [,] CreatingArr(int row, int col, int from, int to)
{
    double [,] arr = new double[row, col];
    Random elements = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = Math.Round(elements.NextDouble() * (to - from ) + from, 2);
        }
        return arr;
}

void PrintArr(double [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr[i, j], 6} ");
        Console.WriteLine();
    }
}
Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());
Console.Write("Input bigining number ");
int from = int.Parse(Console.ReadLine());
Console.Write("Input final number ");
int to = int.Parse(Console.ReadLine());
double [,] test = CreatingArr (row, col, from, to);
PrintArr(test);