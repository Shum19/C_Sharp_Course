/*Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
*/
Console.Write("Введите число 1- ");
int digit1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2- ");
int digit2 = int.Parse(Console.ReadLine());

int result = digit1 / digit2;

if (result == digit2){

    Console.WriteLine("Число 1 является квадратом " + digit1);
}else{
    
    Console.WriteLine("Попробуйте вести другое число");
}
