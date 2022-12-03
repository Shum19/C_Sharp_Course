/*  Задача 3: Напишите программу, которая принимает на вход число (N) и 
    выдаёт таблицу кубов чисел от 1 до N. 
    3 -> 1, 8, 27.
    5 -> 1, 8, 27, 64, 125
*/ 
int InputData(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int number = text == null ? 0 : int.Parse(text);
    return number;
}

/*void TableOfCubic (int digit) 
{
    int i = 1;
    double  table = 0;
    while (i <= digit)
    {
        if (i == digit)
        {
            table = Math.Pow (i, 3);
            Console.Write($"{table}.");
        }
        else 
        {
            table = Math.Pow(i, 3);
            Console.Write($"{table}, ");
        }
        i++;
    }
}

int test = InputData("Write a digit ");
TableOfCubic(test);
*/

// решение с преобразованием в массив
void TableOfCubic (int digit) 
{
    int i = 0;
    double  [] table = new double [digit];
    while (i < digit)
    {
        if (i == digit-1)
        {
            table [i] = Math.Pow (i + 1, 3);
            Console.Write($"{table[i]}.");
        }
        else 
        {
            table [i] = Math.Pow(i + 1, 3);
            Console.Write($"{table[i]}, ");
        }
        i++;
    }
}

int test = InputData("Write a digit ");
TableOfCubic(test);