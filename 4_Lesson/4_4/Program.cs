/*  Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
    заполненный нулями и единицами в случайном порядке.
    [1,0,1,1,0,1,0,0] 
*/int InputDate(string msg)
{
    Console.Write(msg);
    string text = Console.ReadLine();
    int digit = text == null ? 0 : int.Parse(text);
    return digit;
}
void ArrayPrint(int numOfElements)
{
    int [] arr = new int [numOfElements];
    int size = arr.Length -1;
    for (int i = 0; i <= size; i++)
    {
        arr [i] = new Random().Next(0, 2);
        Console.Write($"{arr[i]}, ");
    }
}
int test = InputDate("Write num of elements ");
Console.WriteLine();
ArrayPrint(test);