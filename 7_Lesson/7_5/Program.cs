/*  Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
    выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.  
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

void FindPosit(int [,] arr, int digit)
{
    Console.Write("Input digit to find its position in array - ");
    digit = int.Parse(Console.ReadLine());
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
   // int col = 0;
   // int row = 0;
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
        {
            if (arr [i, j] == digit)
            {
                Console.Write("[" + $" {i + 1}, {j + 1} " + "]");
                return;
            }
            else 
            {
                Console.Write("Not found");
                return;
            }
        }
    }
}

int [,] test = TwoDimensArr(3, 4, 1, 10);
PrintArr(test);
Console.WriteLine();
FindPosit(test, 5);