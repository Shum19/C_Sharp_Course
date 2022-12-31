/*  Задача 5: Вывести первые N строк треугольника Паскаля. 
    Сделать вывод в виде равнобедренного треугольника
*/
Console.Clear();
void PascalTriangle ()
{
    Console.Write("Input number of rows ");
    string text = Console.ReadLine();
    int numOfRows = text == null ? 0 : int.Parse(text);
    int i, j, val = 1,
        space;
    for (i = 0; i < numOfRows; i++)
    {
        for (space = 1; space <= numOfRows-i; space++)
            Console.Write("_");
        for (j = 0; j <= i; j++)
        {
            if (j == 0 || i == 0)
                val = 1;
            else
                val = val * (i - j + 1) / j;
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}
PascalTriangle();