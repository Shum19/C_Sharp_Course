/*  Задача 1: Напишите программу замена элементов массива: положительные элементы замените 
    на соответствующие отрицательные, и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int [] CreatingArr(int size, int from, int to)
{
    int [] arr = new int [size];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next( from, to + 1);
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(" -> ");
    return arr;
}
void ExchangeNegPos (int [] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
            Console.Write($"{array[i]}, ");
    }
}

int [] test = CreatingArr(  int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
ExchangeNegPos(test);
