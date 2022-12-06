/*  Задача 3: Задайте одномерный массив из 123 случайных чисел.
    Найдите количество элементов массива, значения которых лежат в
    отрезке [10,99].
    Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
    [5, 18, 123, 6, 2] -> 1
    [1, 2, 3, 6, 2] -> 0
    [10, 11, 12, 13, 14] -> 5
*/
int [] CreatingArr(int size, int from, int to)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(from, to + 1);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}
void SumOfElements (int [] array, int init, int fin)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= init && array [i] <= fin)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
int [] test = CreatingArr( int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
SumOfElements(test, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
