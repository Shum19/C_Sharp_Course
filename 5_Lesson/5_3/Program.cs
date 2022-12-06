/*  Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли 
    заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет 
    3; массив [6, 7, 19, 345, 3] -> да
*/
int [] CreatingArr (int size, int from, int to) 
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(from, to + 1);
        Console.Write($"{arr[i]} ");
    }
    Console.Write(" - > ");
    return arr;
}

Boolean isDigitHere(int [] array, int digit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] == digit) return true;
    }
        return false;
}
int [] test = CreatingArr( int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine(isDigitHere(test, int.Parse(Console.ReadLine())));
