/*  Задача 4: Напишите программу, которая принимает на вход цифру, 
    обозначающую день недели, и проверяет, является ли этот день выходным.
*/ 

String isHollyday (int number)
{    
    int Mon = 1;
    int Tue = 2;
    int Wen = 3;
    int Thi = 4;
    int Fri = 5;
    int Sat = 6;
    int Sun = 7;
        if ( number == Sat || number == Sun)
        {
            return "Today is Hollyday! Huray!!!:)";
        }
        else if (number > 7)
        {
            return "There are 7 days in a week! Try again insert right digit";
        } 
        else 
            return "Today is workin day :(";
    }

Console.Write("Put number 1 to 7 ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine (isHollyday(number));

