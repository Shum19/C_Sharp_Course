/*  Напишите программу, которая выводит третью цифру 
    заданного числа или сообщает, что третьей цифры нет.
*/ 
String ShowThirdDigit (long number)
{    
    if (number > 999) 
    {   
        long i = number;
        while( i > 1000)
        {
            number /= 10;
            i /=10;
        }
    }
    else if (number > 99 && number < 1000)
    {
        number %= 10;
        return $"The third digit is {number}";
    }
    else if (number < 100) 
    {
        return "Threre is no third digit!";
    }
    number %= 10;
    return $"A third digit of big number is {number}!";
}


Console.Write("Put a number and find a third digit ");
long number = long.Parse(Console.ReadLine());
Console.WriteLine(ShowThirdDigit(number));



