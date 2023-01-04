/*  Задача 1: Задайте значения M и N. Напишите программу, 
    которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
    M = 1; N = 5 -> "2, 4"
    M = 4; N = 8 -> "4, 6, 8"
*/
Console.Clear();
void EvenNumbersFromTo (int from, int to)
{
    if (from > to) return;
    if (from % 2 != 0) from = from + 1;
    Console.Write($"{from}, ");
    EvenNumbersFromTo(from+2, to);
}
EvenNumbersFromTo(-10, 10);