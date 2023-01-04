/*  Задача 3: Напишите программу, которая будет принимать на вход 
    число и возвращать сумму его цифр. Использовать рекурсию.
    453 -> 12   
    45 -> 9
*/
Console.Clear();
int SumOfNumber (int digit)
{
    if (digit == 0) return 0;    
    return digit%10 + SumOfNumber(digit/10);
}
Console.WriteLine(SumOfNumber(453));