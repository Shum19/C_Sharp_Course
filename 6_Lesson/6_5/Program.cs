/*  Задача 4: Напишите программу, которая будет создавать копию заданного массива 
    с помощью поэлементного копирования.
*/
Console.Clear();

int [,] FillAray(int row, int columns)
{
    int [,] arr = new int [row, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0;  j < arr.GetLength(1); j++)
       {
            arr[i, j] = new Random().Next(10, 101); 
       }
    }
    return arr;
}

void PrintArr(int [,] array)
{
    int row = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [,] CopyArr( int [,] array)
{
    int row = array.GetLength(0);
    int columns = array.GetLength(1);
    int [,] newArr = new int [row, columns];
    for (int i = 0; i < row; i++)
    {
       for (int j = 0;  j < columns; j++)
       {
            newArr[i, j] = array[i, j]; 
       }
    }
    return newArr;
}

int [,] test = FillAray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
PrintArr(test);
CopyArr(test);
PrintArr(test);