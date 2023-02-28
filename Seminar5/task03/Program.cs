// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да
//нам нужно задать число и методом перебора сравнивать каждый элемент массива
//1. Решение через bool переменную 
// int[] GeneretArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }
// bool FindNumber(int[] array, int number)//ф-я поиска числа, обявляем целочисл массив и число 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;// значит правда
//         }
//     }
//     return false;
// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }
// int[] myArray = GeneretArray(20, -9, 9);
// int number = 7;
// PrintArray(myArray);
// if (FindNumber(myArray, number))
// {
//     System.Console.WriteLine("Да, такой элемент есть");
// }
// else
// {
//     System.Console.WriteLine("Такого элемента нет");
// }
//2. Решение через void
int[] GeneretArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
void FindNumber(int[] array, int number)//ф-я поиска числа, обявляем целочисл массив и число 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            System.Console.WriteLine("Такой элемент есть");
            return;
        }
    }
    System.Console.WriteLine("Такого элемента нет");
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int[] myArray = GeneretArray(20, -9, 9);
int number = 7;
PrintArray(myArray);
FindNumber(myArray, number);
