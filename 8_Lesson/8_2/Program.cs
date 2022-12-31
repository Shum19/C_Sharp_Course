/*  Задача 2: Задайте двумерный массив. Напишите программу, 
    которая заменяет строки на столбцы. В случае, если это невозможно, 
    программа должна вывести сообщение для пользователя.
*/
Console.Clear();

int [,] CreatingArr(int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(1, 11);
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

int [,] ChangeLinesWithCol(int [,] arr)
{
    int col_size = arr.GetLength(0);
    int row_size = arr.GetLength(1);
    if (row_size != col_size)
    {
        Console.Write("Yoy have to input equal number of row and column");
        return arr;
    }
    else
    {
        for (int j = 0; j < col_size; j++)
            for (int i = 0; i < j; i++)
                (arr[j, i], arr [i, j]) = (arr [i, j], arr[j, i]);
    }
    PrintArr(arr);
    return arr;
}


Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
PrintArr(test);
Console.WriteLine();

ChangeLinesWithCol(test);
Console.WriteLine();
//PrintArr(test);

