/*  Задача 1: Напишите программу, которая перевернёт одномерный массив 
    (последний элемент будет на первом месте, а первый - на последнем и т.д.)
    [1 2 3 4 5] -> [5 4 3 2 1] 
    [6 7 3 6] -> [6 3 7 6]
    
*/

Console.Clear();
int [] CreatingArray (int size, int from, int to)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void PrintArray (int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

void ReverseArray (int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        (array[i], array[size - i - 1]) = (array[size - i - 1], array[i]);
    }
}

int [] test = CreatingArray(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
PrintArray(test);
ReverseArray(test);
PrintArray(test);
