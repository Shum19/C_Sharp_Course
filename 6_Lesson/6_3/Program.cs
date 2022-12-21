/*  Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
    45 -> 101101 
    3 -> 11
    2 -> 10
*/
Console.Clear();
string ConvertToBinary (int digit)
{
    string result = string.Empty;
    while(digit > 0)
    {
        result = digit%2 + result;
        digit /= 2;
        
    }
    return result;
}
int test = int.Parse(Console.ReadLine());
Console.Write(ConvertToBinary(test));