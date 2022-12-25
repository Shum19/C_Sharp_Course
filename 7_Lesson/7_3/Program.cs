/*  Задайте двумерный массив. Найдите элементы,
    у которых обе позиции чётные, и замените эти элементы на их квадраты.
*/
Console.Clear();

int [,] TwoDimensArr(int row, int col, int from, int to)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr [i, j] = new Random().Next(from, to+1);
    return arr;
}

void PrintArr(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($"{arr [i, j], 4}");
        Console.WriteLine();
    }
}

int [,] DoubleEvenPos (int [,] arr)
{
    int row_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 1; i < row_size; i += 2)
    {
        for (int j = 1; j < columns_size; j += 2)
        {
            arr [i, j] *= arr [i, j];
        }
    }
    return arr;
}


int [,] test = TwoDimensArr(4, 4, 1, 10);
PrintArr(test);
Console.WriteLine();
DoubleEvenPos(test);
PrintArr(test);