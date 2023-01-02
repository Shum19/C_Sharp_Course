/*  Задача 3: Задайте две матрицы. Напишите программу, 
    которая будет находить произведение двух матриц.
*/
Console.Clear();
int[,] CreatingArr()
{
    Console.Write("Matrix with equal numbers of rows and columns " +
                    "could be multiplied" + "\nInput number for " +
                    "rows and columns ");
    string textNumber = Console.ReadLine();
    int row = textNumber == "" ? 0 : int.Parse(textNumber);
    int col = row;
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(1, 11);

    return arr;
}

void PrintArr(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
}

int[,] MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int row1_size = arr1.GetLength(0),
        col1_size = arr1.GetLength(1),
        col2_size = arr2.GetLength(1);
    int[,] multip_arr = new int[row1_size, col1_size];
    int i, j, p, count = 0;
    if (row1_size != col2_size)
        Console.WriteLine("Wrong Matrix");
    else
    {
        for (i = 0; i < row1_size; i++)
        {
            for (j = 0; j < col1_size; j++)
            {
                count = 0;
                for (p = 0; p < col1_size; p++)
                    count = count + (arr1[i, p] * arr2[p, j]);
                multip_arr[i, j] = count;
            }
        }
    }
    return multip_arr;
}
int[,] test1 = CreatingArr();
PrintArr(test1);
Console.WriteLine();

int[,] test2 = CreatingArr();
PrintArr(test2);
Console.WriteLine();

int[,] test3 = MultiplyArrays(test1, test2);
PrintArr(test3);