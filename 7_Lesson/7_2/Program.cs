/*  2.Задайте двумерный массив размера m на n,
    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
    Выведите полученный массив на экран.
*/
Console.Clear();
int [,] TwoDimensArr(int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr [i, j] = i + j;
    return arr;
}
void PrintArr(int [,] array)
{
    int row_size = array.GetLength(0);
    int columns_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($"{array [i, j], 4}");
        Console.WriteLine();
    }
}



int [,] test = TwoDimensArr(3, 4);
PrintArr(test);