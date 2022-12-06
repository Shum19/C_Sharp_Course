/*  Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
    Найдите сумму отрицательных и положительных элементов массива.
    Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
    сумма отрицательных равна -20.
*/
int [] CreatingArr()
{
    Console.Write("Write array nummber elements ");
    int elements = int.Parse(Console.ReadLine());
    Console.Write("Write including from ");
    int from = int.Parse(Console.ReadLine());
    Console.Write("Write including to ");
    int to = int.Parse(Console.ReadLine()) + 1;
    int [] arr = new int [elements];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr [i] = new Random().Next(from, to);
        Console.Write($"{arr[i]}, ");
        
    }
    return arr;
}
void PosNegSum(int[] array)
{
    int negCount, posCount;
    posCount = negCount = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0)
        {
            array [i] *= -1;
            negCount = negCount + array[i];
        }
        else
        {
            posCount = posCount + array[i];
        }
    }
        Console.WriteLine($"Sum of Neg is {negCount}");
        Console.WriteLine($"Sum of Pos is {posCount}");
}

int [] test = GreatingArr();
Console.WriteLine();
PosNegSum(test);

