// Напишите программу, которая выводит случайное трехзначное число 
// и на выходе показывает последнюю цифру этого числа.
int ShowLastDigit (int number)
{
    Console.WriteLine(number);
    Console.WriteLine(number %= 10);
    return number %= 10;

}


ShowLastDigit(new Random().Next(10, 1000));