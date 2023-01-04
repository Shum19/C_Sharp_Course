/*  Задача 2: Задайте значения M и N. Напишите программу, которая 
    рекурсивно выведет все натуральные числа в промежутке от M до N.
    M = 1; N = 5 -> "1, 2, 3, 4, 5" 
    M = 4; N = 8 -> "4, 6, 7, 8"
*/
Console.Clear();
void PrintNumbersFromTo(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    PrintNumbersFromTo (m+1, n);
}
PrintNumbersFromTo(1, 5);
Console.WriteLine( 1/10);