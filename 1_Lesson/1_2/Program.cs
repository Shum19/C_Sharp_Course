/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/
Console.Write("Введите число от 1 до 7 - ");
int digit =int.Parse(Console.ReadLine());

if (digit == 1){
    Console.WriteLine("Вы выбрали Понедельник");

}else if (digit == 2){
    Console.WriteLine("Вы выбрали Вторник");

}else if (digit == 3){
    Console.WriteLine("Вы выбрали Среда");

}else if (digit == 4){
    Console.WriteLine("Вы выбрали Четверг");

}else if (digit == 5){
    Console.WriteLine("Вы выбрали Пятница");

}else if (digit == 6){
    Console.WriteLine("Вы выбрали Суббота");

}else if (digit == 7){
    Console.WriteLine("Вы выбрали Воскресенье");
}