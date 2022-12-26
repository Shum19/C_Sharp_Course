/*  Задача 2: Напишите программу, которая на вход принимает позиции элемента 
    в двумерном массиве, и возвращает значение этого элемента или же указание, 
    что такого элемента нет.
    Например, задан массив: 
    1 4 7 2
    5 9 2 3 
    8 4 2 4
    1 7 -> такого числа в массиве нет
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

void PrintArr(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {  for (int j = 0; j < col_size; j++)
            Console.Write($"{arr [i, j], 4} ");
        Console.WriteLine();
    }
}

void FindArrayNumvber(int [,] arr, int row_pos, int col_pos)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    
    if (row_pos == 0 || col_pos == 0)
        Console.Write("Positions start from 1 ");
    else if (row_pos > row_size || col_pos > col_size)
        Console.Write($"Position {row_pos}, {col_pos} is not found");
    else
        Console.Write($"{arr [row_pos - 1, col_pos - 1]}");
}
Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
PrintArr(test);

Console.Write("Input row position ");
int rowPosition = int.Parse(Console.ReadLine());
Console.Write("Input column position ");
int columnPosition = int.Parse(Console.ReadLine());

FindArrayNumvber(test, rowPosition, columnPosition );