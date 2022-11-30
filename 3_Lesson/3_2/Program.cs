/*  Напишите программу, которая по заданному номеру четверти, показывает 
    диапазон возможных координат точек в этой четверти (x и y)
*/

void RangeOfDigit (string quater)
{
      
    if (quater == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if (quater == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if (quater == "III")
        Console.WriteLine("x < 0 and y < 0");
    else if (quater == "IV")
        Console.WriteLine("x > 0 and y < 0");
}
Console.Write("Write a quater "); 
RangeOfDigit (Console.ReadLine());