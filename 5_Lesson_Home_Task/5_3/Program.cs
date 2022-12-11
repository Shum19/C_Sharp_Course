/*  Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
    минимальным элементов массива.
    [3 7 22 2 78] -> 76
*/
Console.Clear();

double [] CreatingArray (int size)
{
    double [] arr = new double [size];
    Random elements = new Random ();
    
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = Math.Round(elements.NextDouble()*100, 2);
        Console.Write($"{arr [i]} ");
    }
    Console.Write("] - > ");
    return arr;
}

void DifferencOfMaxMin (double[] array)
{
    double max = array [1];
    double min = array [2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) 
        {
            max = array[i];
        }
        else if (array [i] < min)
        {
            min = array [i];
        }
    }
    Console.Write (Math.Round((max - min), 2));
    Console.WriteLine();
    Console.WriteLine($"Max is {max}, Min is {min}");
    
}

double [] test = CreatingArray (int.Parse(Console.ReadLine()));
DifferencOfMaxMin(test);
