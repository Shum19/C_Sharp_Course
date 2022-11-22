/*Задача No3. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/
Console.Write("Введите положительное число - ");
int posDigit = int.Parse(Console.ReadLine());
int negDigit = - posDigit;
int i = negDigit;

while (i <= posDigit)
{
Console.Write($"{i}, ");
i++;  
}
