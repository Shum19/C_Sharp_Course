/*  Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/
int [] CreatingArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(100, 1000);
        Console.Write($"{arr [i]} ");
    }
    Console.Write("- >");
    return arr;
}
void SumOfEven (int [] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write(count);
}

int [] test = CreatingArray(int.Parse(Console.ReadLine()));
SumOfEven(test);
