/*  Задача 2: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку 
    с наименьшей суммой элементов.
*/
Console.Clear();

int [,] CreatingArr ()
{
    Console.Write("Input number of rectangular array ");
    string textNumber = Console.ReadLine();

    int row = textNumber == "" ? 0 : int.Parse(textNumber);
    int col = row;
    int [,] arr = new int [row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(0, 11);
    return arr;
}

void PrintArr(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i <row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr[i, j], 4}");
        Console.WriteLine();
    }
}

int MinSumOfRow (int [,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int sum = 0,
        min = 0;
    for (int i = 0; i < row_size; i++)
    {
        sum = 0;
        for (int j = 0; j < col_size; j++)
        {   if (i == 0) min += arr[i, j];
            sum += arr[i,j];
        }
        Console.WriteLine($"Summary of row {i+1} = {sum} ");
        if (sum < min) min = sum;
    }
    
    return min;  
}


int [,] test = CreatingArr();
PrintArr(test);
int test2 = MinSumOfRow(test);
Console.WriteLine("Minimum summary of row " + test2);