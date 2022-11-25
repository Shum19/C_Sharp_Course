// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
String Divisible(int number)
{
    
    if (number % 7 == 0 && number % 23 == 0)
    {
    //Console.WriteLine(number);
    return $"{number} is divisible of 7 and 23";
    }
    else
    {
        //Console.WriteLine(number);
        return $"{number} is not divisible, try again";

    }
}

Console.Write("Put a number - ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Divisible(number));
