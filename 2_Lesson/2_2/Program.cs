// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int isNumberDivisible(int firstNum, int secondNum)
{
    Console.WriteLine(firstNum + ", " + secondNum);
    if (firstNum % secondNum == 0)
    {
    Console.WriteLine(0);
    return 0;
    }
    else
    {
        Console.WriteLine(firstNum %= secondNum);
        return firstNum %= secondNum;

    }
}

Console.Write("Первое число - ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Второе число - ");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine(isNumberDivisible(firstNum, secondNum) * 10);// умножил на 10 чтобы проверить return
