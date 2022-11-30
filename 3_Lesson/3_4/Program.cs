/*  Задача 4: Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу квадратов чисел от 1 до N.
    5 -> 1, 4, 9, 16, 25. 
    2 -> 1,4
*/
int InputData(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int number = text == null ? 0 : int.Parse(text);
    return number;
}

void TableOfSqrt(int number)
{
    int i = 1;
    double pow;
    while (i < number + 1)
    {
        if (i <= number - 1)
        {
            pow = Math.Pow(i, 2);
            Console.Write($"{pow}, ");
        }
        else
        {
            pow = Math.Pow(i, 2);
            Console.Write($"{pow}.");
        }
        i++;
    }

}

int number = InputData("Write digit ");
TableOfSqrt(number);