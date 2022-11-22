/*See https://aka.ms/new-console-template for more information
*/
Console.Write("Введите число - ");
int digit = int.Parse(Console.ReadLine());

if (digit < 0){
    digit = -1 * digit;
    Console.WriteLine("Модуль " + "-" + digit + " = " + digit);
}else {
Console.WriteLine("Модуль " + digit + " = " + digit);
}
//Console.WriteLine(digit * -1);


