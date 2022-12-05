/*  Задача 1: Напишите программу, которая принимает на вход число (А) 
    и выдаёт сумму чисел от 1 до А.
    7 -> 28 
    4 -> 10 
    8 -> 36
*/
int InputDate (string message)
{
    Console.Write(message);
    string text = Console.ReadLine ();
    int number = text == null ? 0 : int.Parse(text);
    return number;
}
void SumNums(int digit)
{
    int count = 0;
    for (int i = 1; i <= digit; i++)
    {
        count = count + i;
    }
    Console.Write($"{digit} - > {count}");
}
int test = InputDate("Write number ");
Console.WriteLine();
SumNums(test);