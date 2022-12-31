/*  Задача 3: Составить частотный словарь элементов двумерного массива. 
    Частотный словарь содержит информацию о том, сколько раз встречается 
    элемент входных данных. Значения элементов массива 0..9
*/
Console.Clear();
int [,] CreatingArr (int row, int col)
{
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(0, 10);
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

void PrintMass (int [] arr)
{
    int size = arr.Length;
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} meets: {arr [i]} ");
}

int [] FrequencyDict (int [, ] arr)
{
    int [] freq = new int [10];
    foreach (int item in arr)
        freq[item] +=1;
    return freq;
}

Console.Write("Input number of row ");
int row = int.Parse(Console.ReadLine());
Console.Write("Input number of colimns ");
int col = int.Parse(Console.ReadLine());

int [,] test = CreatingArr(row, col);
PrintArr(test);
Console.WriteLine();

int [] test2 = FrequencyDict(test);
PrintMass(test2);