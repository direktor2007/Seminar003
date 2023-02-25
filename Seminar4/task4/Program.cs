// Задача 30: Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// 1. Решение простое
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i=0; i<count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// int[] arr = new int [8];
// for (int i = 0; i < 8; i++)
// {
//     arr[i] = new Random().Next(0,2);
// }
// PrintArray(arr);
//2. Решение через функции
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i=0; i<count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// int[] FillArray(int size)// указали не 8, а size, Вдруг если мы захотим чтоб цифр было 12
// {
//     int[] arrN = new int[size];// и здесь size
//     for (int i = 0; i < 8; i++)
//     {
//         arrN[i] = new Random().Next(0,2);
//     }
//     return arrN;
// }
// int[]myArray = FillArray(8);
// PrintArray(myArray);
//3. Решение простой метод. Еще можно так. Артем.

// int[] arr = new int[8];
// var rand = new Random ();
// for (int i= 0 ; i<arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }
// for (int i= 0 ; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }

//4. Решение с функцией

// int[] GetArray()
// {
//     int[] arr = new int[8];
//     var rand = new Random ();
//     for (int i= 0 ; i<arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }
// return arr;
// }

// void PrintArray(int[]arr)
// {
//     //// for (int i= 0 ; i < arr.Length; i++)
//     //// {
//     //// System.Console.Write(arr[i] + " ");
//     //// }
//     System.Console.WriteLine("["+string.Join(", ", arr)+"]");//конструкция стринг джоин
// }

// var myArray = GetArray();
// PrintArray(myArray);

//5. Если мы ввод сделаем через void,то это будет выглядеть так:
void GetArray(int[] arr)
{
    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}
void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");//конструкция стринг джоин
}
int[] myArray = new int[8];// выделим память под массив
GetArray(myArray);//в функцию GetArray передаю созданный массив, и внутри функции GetArray он обращается 
//к данному массиву как по ссылке , т.е. он обращается к памяти массива. 
//Значит если я пишу , что I-ый элемент arr равен рандомному значению, 
//то он записывает это рандомное значение в ячейку памяти массива, в который передаю. 
//Ссылка помогает не создаваю новую переменную обращаться к интересующей нам переменной 
PrintArray(myArray);