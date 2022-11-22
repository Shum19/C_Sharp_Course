/* Напишите программу, которая на вход принимает число и выдает его квадрат 
(число умноженное на само себя)
Например 4 -> 16; -3 -> 9; -7 -> 49;
*/
Console.Write("Введите число и оно будет возведено в квадрат - ");
int digit = int.Parse(Console.ReadLine());
int result = digit * digit;
Console.WriteLine( digit + " в квадрате = " + result);
