/*  Задача 1: Напишите программу, которая принимает на вход три числа и проверяет,
    может ли существовать треугольник с сторонами такой длины.
    Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.Clear();
Console.Write("Input number 3 first - ");
int [] CreatArry (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input side of triangle {i+1} - ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Boolean CanBeTriangle (int [] array)
{
    int a = array[0];
    int b = array [1];
    int c = array [2];
    if (a < b + c & b < a + c & c < a + b) return true;
    return false;
}

int [] test = CreatArry(int.Parse(Console.ReadLine()));
PrintArray(test);
Console.WriteLine(CanBeTriangle(test));
