/*  Задайте двумерный массив размерам m на x заполненый случайными целыми числами
    m = 3, n = 4.
    1  4  8  19
    5 -2  33 -2
    77 3   8  1

*/
Console.Clear();
int [,] RandomArr(int row, int columns, int from, int to)
{
    int [,] arr  = new int [row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr [i, j] = new Random().Next(from, to+1);
        }
    }
    return arr;
}

void PrintArr(int [,] array)
{
    int row_size = array.GetLength(0);
    int columns_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
        {
            Console.Write($"{array [i,j], 4} ");
        }
        Console.WriteLine();
    } 
}

int [,] test = RandomArr(3, 4, 1, 50);
PrintArr(test);