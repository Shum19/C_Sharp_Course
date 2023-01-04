/*  Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
    сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
    M = 1; N = 15 -> 120 
    M = 4; N = 8 -> 30
*/
Console.Clear();
int SummaryFromTo(int from, int to)
{
    if (from > to) return 0;
    return SummaryFromTo(from+1, to) + from;
}
Console.Write(SummaryFromTo(1, 15));