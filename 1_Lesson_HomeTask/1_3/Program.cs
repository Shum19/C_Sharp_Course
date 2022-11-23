/*Задача 3: Напишите программу, которая на вход принимает число и выдает, 
является ли число четным (делится ли оно на два без остатка).
*/
Console.Write("Введите число для - ");
string input  = Console.ReadLine();
int digit = input == null ? 0 : int.Parse(input);

if ( digit%2 == 0) 
{
    Console.WriteLine($"Введенное число {digit} является четным");
}else
{
    Console.WriteLine ($"Число {digit} нечетное");
}