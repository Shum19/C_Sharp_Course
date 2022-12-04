/*  Задача 2: Напишите программу, которая принимает на вход число 
    и выдаёт сумму цифр в числе.
    452 -> 11 
    82 -> 10 
    9012 -> 12
*/
//Функция ввода данных
int InputDate(string msg)
{
    Console.Write(msg);
    string text = Console.ReadLine();
    int number = text == null ? 0 : int.Parse(text);
    return number;  
}
// Функция складывает чиcла по отделности
int SumOfDigits (int digit)
{
    int result = 0;
    // пустая строка для того чтобы вывести по отдельности цифры введденного числа
    string splitDigits = string.Empty;
    // индекс начинается от введеного чисда и цикл отрабатыает пока индекс не достиигнет больше нуля
    // шаг при этом убирает одну цифру от введеного числа
    for (int i = digit; i > 0; i = i/10)
    {
        // отделяем числа для вывода строки но пока не понимаю как вывестии правильный порядок цифр
        // выводятся от последнего и до первого
        splitDigits = splitDigits + $"{i%10}, ";
        // данная строка получает только посдеднею цифру от введеного числа и идет по циклу сокрощая
        // введеное число на последнюю цифру
        digit = i%10;
        // последнию цифру складываем с каждой итерацией для получения суммы
        result =  result + digit; 
        
    }
    Console.Write($"The summary of digits " + splitDigits + $"= {result}.");
    return result;
}
int test = InputDate("Write a number ");
SumOfDigits(test);
