/*  Задача 1: Напишите программу, которая принимает на вход число 
    и выдаёт количество цифр в числе.
    456 -> 3 
    78 -> 2 
    89126 -> 5
*/
int InputDate(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int digit = text == null ? 0 : int.Parse(text);
    return digit;
}
void Quantities(int number)
{
    if (number == 0) Console.Write(1);
    else
    {
        int i = 0;
        if (number < 0)
        {
            number = number * (-1);
            while (number > 0)
            {
                number /= 10;
                i++;
            }
        }
        else
        {
            while (number > 0)
            {
                number /= 10;
                i++;
            }
        }
        Console.WriteLine(i);
    }
}
int test = InputDate("Write number ");
Console.WriteLine();
Quantities(test);