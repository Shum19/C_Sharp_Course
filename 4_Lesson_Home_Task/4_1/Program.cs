/*  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
    и возводит число A в натуральную степень B.
    3, 5 -> 243 (35) 
    2, 4 -> 16
*/ 
// Функция создает массив из двух элементов
int [] InputDate ()
{
    int [] arr = new int [2];
    int size = arr.Length;
    int i = 0;
    // Цикл для ввода элементов
    while (i < size)
    {   // первый if для того чтобы вывести строку что это число A и ввести 1-й эдемнет массива
        if (i == 0)
        {
            Console.Write("Write digit of A: ");
            arr [i] = int.Parse(Console.ReadLine());
        }
        //else для того чтобы вывести строку что это число B и ввести 2-й эдемнет массива
        else 
        {
            Console.Write("Write digit of B: ");
            arr [i] = int.Parse(Console.ReadLine());
        }
        i++;
    }
    Console.WriteLine($"The Digit {arr[0]} will be raised to the power of Digit {arr[1]}");
    return arr;
    

}
// Функция возводит число A в степень B 
void RaisedFunc (int A, int B)
{
    int count = 1;
    for (int j = 1; j <= B; j++)
    {
        count = count * A;
    }
    Console.WriteLine ($"The answer of exepression {A}^{B} = {count}");
}
// Строка создает массив из 2 чисел
// А элементы буддет те которые я введу через консоль
int [] test = InputDate();
// Функция возведения в степень которая использует элементы массива который ииницилизирован выше другой
// фунццией
RaisedFunc(test[0], test[1]);
