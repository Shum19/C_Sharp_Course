/* Задача 1: Напишите программу, которая на вход принимает два 
   числа и выдает, какое число большее, а какое меньшее.
*/
Console.Write("Введите число 1- ");
int digit1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2- ");
int digit2 = int.Parse(Console.ReadLine());

if (digit1 >= digit2){
    Console.WriteLine("Max = " + digit1);
}else {
    Console.WriteLine("Max = " + digit2);
}
