/*  Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет 
    местами первую и последнюю строку массива.
*/
Console.Clear();
int [,] CreatingArr (int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr [i, j] = new Random().Next(1, 11);
    return arr;
}

void PrintArr(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr[i, j], 4}");
        Console.WriteLine();
    }
}

void ChangeFirstLastLines (int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int j = 0; j < col_size; j++)
    {
        
        (arr [0, j], arr [row_size-1, j]) = (arr [row_size-1, j], arr [0, j]);
        
    }
}

Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
PrintArr(test);
Console.WriteLine();
ChangeFirstLastLines(test);
PrintArr(test);