/*  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
    сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
*/
Console.Clear();
int[] InputNumbers ()
    {
        string nums;
        int [] arr = new int [150];
        int i = 0;
        while (i < arr.Length)
        {
            Console.Write($"Input digit № {i+1} - ");
            nums = Console.ReadLine();
            if (nums == string.Empty) break;
            arr [i] = int.Parse(nums);
            i++;
        }
        // Не убиираю комментарий так как прошу вас посмотрреть код ниже и помочь разобраться
        // почему элементы arr [i] равны 0 не смотря на то что я вводила числа в консоль
        // в предыдущем цикле?
        // и таки образом у меня новыц массив заполняется 0 с количеством элементов равное i
        int [] newArr = new int [i];
            for (int j = 0; j < newArr.Length; j++)
            {
                newArr [j] = arr [j];
            }
          return newArr;
        
        /*Array.Resize(ref arr, i);
        return arr;*/
    }

void PrintArr(int [] arr)
    {
        Console.Write("[ ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr [i]} ");
        }
        Console.Write("] - > ");
    }
void FindDigitAboveZero(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) count++;
    }
    Console.WriteLine(count);

}
int [] test = InputNumbers();
PrintArr(test);
FindDigitAboveZero(test);
        


