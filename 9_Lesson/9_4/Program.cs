﻿/*  Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
    и возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3^5) 
    A = 2; B = 3 -> 8
*/
Console.Clear();
int MyPowRecMethod (int number, int power)
{
    if (power == 0) return 1;
    return MyPowRecMethod (number, power - 1) * number;
}
Console.Write(MyPowRecMethod(2, 3));