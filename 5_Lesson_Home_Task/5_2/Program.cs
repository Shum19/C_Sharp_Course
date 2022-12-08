/*  Задача 2: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 26
    [-4, -6, 4, 6] -> 0
  
*/
Console.Clear();
int [] CreatingArray (int size)
{
    int [] arr = new int [size];
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(-100, 101);
        Console.Write($"{arr [i]} ");
    }
    Console.Write("] - > ");
    return arr;
}

void OddPositionSum(int [] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 0; i < size; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.Write(sum);
}


int [] test = CreatingArray (4);
OddPositionSum(test);
