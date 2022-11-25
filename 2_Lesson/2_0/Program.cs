// Напишите программу, которая выводит случайное число из отрезка 
//  [10, 99] и показывает наибольшую цифру числа.
 
 int MaxDigit (int num)
 {
    Console.WriteLine(num);
    if (num % 10 > num / 10)
        return num % 10;
    else 
        return num / 10;
 }
Console.WriteLine(MaxDigit(new Random().Next(1,100)));