/*  Задача 4: Найдите произведение пар чисел в одномерном массиве. 
    Парой считаем первый и последний элемент, второй и предпоследний
    и т.д. Результат запишите в новом массиве. 
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21
 */
 int [] CreatingArr (int size, int from, int to)
 {
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(from, to +1);
        Console.Write($"{arr [i]} ");
    }
    Console.WriteLine();
    return arr;
 }

 int [] newArrOfMultip(int [] array)
 {
    int size = array.Length;
    //size = size % 2 > 0 ? (size/2) + 1 : size;
    int flex_size = size / 2 + size % 2;
    int [] newArray=new int [flex_size];
    int i = 0;
    while (i < size / 2)
    {
        newArray [i] = array [i] * array[size-(1+i)];
        Console.Write($"{newArray[i]} ");
        i++;
    }
    //так как новый массиив будет состоять из трех элементов если в старом массиве нечетное кол-во элементов
    //и третий элемент в новом массиве по умолчанию будет нуль 0 то мы делаем проверрку если последний
    //элемент 0 то заменяем его на элемент который будет посереддине из старого массива
    if (newArray[flex_size -1] == 0)
    {
        newArray [flex_size -1] = array [flex_size - 1];
    }
    Console.Write($"{newArray[flex_size - 1]}.");
    return newArray;
 }
int [] test = CreatingArr(  int.Parse(Console.ReadLine()), 
                            int.Parse(Console.ReadLine()), 
                            int.Parse(Console.ReadLine()));
newArrOfMultip(test);