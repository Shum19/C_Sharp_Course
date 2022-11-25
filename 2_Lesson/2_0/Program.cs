// Напишите программу, которая выводит случайное число из отрезка 
//  [10, 99] и показывает наибольшую цифру числа.
 
 int MaxDigit (int num)
 {
    Console.WriteLine(num);
    if (num % 10 > num / 10)     
    {
        Console.WriteLine(num % 10);
        return num % 10;
    }
    else 
    {
        Console.WriteLine(num / 10);
        return num / 10;
    }
    
    
 }
MaxDigit(887);
