/*  Задайте двумерный массив. Найдите сумму элементов главной диагонали.
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
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {   
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr [i, j], 4}");
        Console.WriteLine();
    }
}

void SumDaigon(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int count = 0;
    {
        for (int i = 0; i < row_size; i++)
            for (int j = 0; j < col_size; j++)
                {
                  if (i == j)  
                    count += arr[i, i];
                }
    }
    Console.Write(count);
}
int [,] test = TwoDimensArr(3, 7, 1, 10);
PrintArr(test);
Console.WriteLine();
SumDaigon(test);


