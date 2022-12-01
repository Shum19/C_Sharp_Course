/*  Задача 1: Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет 
    23432 -> да 
    12821 -> да
*/

int InputData(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int number = text == null ? 0 : int.Parse(text);
    return number;
}

String isNumberPalindrome (int digit)
{
    int firstDigit = digit / 10000;
    int secondDigit = digit / 1000 % 10;
    int forthDigit = digit / 10 %10;
    int fifthDigit = digit % 10;
    if ( firstDigit == fifthDigit && secondDigit == forthDigit)
    {
        return $"{digit} is a Palindrome";
    }
    else
        return $"{digit} is NOT a Palindrome"; 
}

int test = InputData("Write a five digit number ");
Console.Write(isNumberPalindrome(test));

