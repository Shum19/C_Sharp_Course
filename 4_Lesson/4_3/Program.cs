/*  Задача 2: Напишите программу, которая принимает на вход число N 
    и выдаёт произведение чисел от 1 до N.
    4 -> 24 
    5 -> 120
*/ 
int InputDate(string msg)
{
    Console.Write(msg);
    string text = Console.ReadLine();
    int digit = text == null ? 0 : int.Parse(text);
    return digit;
}
void Multiple(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count = count * i;
    }
    Console.Write($"{number} - > {count}");
}
int test = InputDate("Write number ");
Console.WriteLine();
Multiple(test);

