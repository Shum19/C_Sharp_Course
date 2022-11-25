/*  Задача 2: Напишите программу, которая выводит случайное 
    трёхзначное число и удаляет вторую цифру этого числа.
*/
String JoinFirstLastDigit(int number)
{
   
    Console.WriteLine(number);
    int firstDigit = number / 100;
    int lastDigit = number % 10; 
    return firstDigit.ToString() + lastDigit.ToString();
}
int number = new Random().Next(100, 1000);
Console.WriteLine(JoinFirstLastDigit(number));
