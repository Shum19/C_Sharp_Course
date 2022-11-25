/*  Задача 1: Напишите программу, которая принимает на вход 
    трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
String ShowSecondDigit(int number)
{
    Console.WriteLine(number);
    
    if (number < 100 || number > 999)
    {
        return "Число не трехзначное";
    }
    else 
    {
        number /= 10;
        number %= 10;
        return $"Второе число - {number}";

    }
}

Console.Write("Put a number -");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(ShowSecondDigit(number));
