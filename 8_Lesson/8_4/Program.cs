/*  Задача 4: Задайте двумерный массив из целых чисел. 
    Напишите программу, которая удалит строку и столбец, 
    на пересечении которых расположен наименьший элемент массива.
    Например, задан массив: 
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Наименьший элемент - 1, на выходе получим следующий массив:
    9 4 2
    2 2 6
    3 4 7
*/
Console.Clear();

int [,] CreatingArr(int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(0, 10);
    return arr;
}

void PrintArr( int[,] arr)
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

int [] FindMinPositElem (int [,] arr)
{
    int [] array = new int [2];
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int min = arr [0, 0];
    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < col_size; j++)
        {
            if (arr [i, j] < min) 
            {   min = arr [i, j];
                array [0] = i;
                array [1] = j;    
                Console.WriteLine($"{min} elements {i}, {j}");
            }
        }
        return array;
}

int [,] DeleteColRow (int [,] arr, int [] mass)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int [,] array = new int [ row_size -1, col_size -1];
    // параметр k и u необходдимы для выдееления памити для нового массива
    for (int i = 0, k = 0; i < row_size; i++)
    {
            if (i == mass[0]) continue;
            for (int j = 0, u = 0; j < col_size; j++)
            {
                if (j == mass [1]) continue;
                array [k, u] = arr[i,j];
                u++;
            }
            k++;
    }
    return array;
}

Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
PrintArr(test);
Console.WriteLine();

int [] arrTest = FindMinPositElem(test);
Console.WriteLine();

int [,] test2 = DeleteColRow(test, arrTest);
PrintArr(test2);



