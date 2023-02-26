// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

//1. Решение с помощью функции
// int[] GeneretArray (int size, int leftRange, int rightRange)// на вход я получаю размер массива, левая граница и правая граница, создающая диапозон
// {
//     int[] array = new int[size];//выделим память размерностью size
//     var rand = new Random();
//     for(int i =0; i < array.Length; i++)
//    {
//     array[i] = rand.Next(leftRange, rightRange + 1);// -9, 9+1 //пройдусь по каждому элементу массива и присваиваю им рандомное значение
//    } 
//    return array;
// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("["+string.Join(", ", array)+"]");//позводяет выводить элементы массива через заданный разделитель
// }
// int SumNegative(int[] array)//ф-я поиска суммы отрицательных чисел
// {
//     int result = 0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]<0)
//         {
//             result+=array[i];
//         }
//     }
//     return result;
// }
// int SumPositive(int[] array)//ф-я поиска суммы положительных чисел
// {
//     int result = 0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             result+=array[i];
//         }
//     }
//     return result;
// }

// int[] myArray = GeneretArray(12, -9, 9);
// PrintArray(myArray);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {SumNegative(myArray)}");
// System.Console.WriteLine($"Сумма положительных элементов равна {SumPositive(myArray)}");

//2. Решение при помощи массива

// int[] GeneretArray (int size, int leftRange, int rightRange)// на вход я получаю размер массива, левая граница и правая граница, создающая диапозон
// {
//     int[] array = new int[size];//выделим память размерностью size
//     var rand = new Random();
//     for(int i =0; i < array.Length; i++)
//    {
//     array[i] = rand.Next(leftRange, rightRange + 1);// -9, 9+1 //пройдусь по каждому элементу массива и присваиваю им рандомное значение
//    } 
//    return array;
// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("["+string.Join(", ", array)+"]");//позводяет выводить элементы массива через заданный разделитель
// }
// int[] SumNegativeAndPozitive(int[] array)
// {
//     int[] result = new int[2];//изначально массив весь заполнен 0-ями
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i] < 0)//отрицательный элемент массива
//         {
//             result[0] += array[i];//прибавим на 0-ую ячейку памяти резалта, в левую колонку
//         }
//         else{                       //иначе
//             result[1] += array[i];  //в правую ячуйку памяти запишем положительные элементы
//         }
//     }
//     return result;
// }

// int[] myArray = GeneretArray(12, -9, 9);
// PrintArray(myArray);
// int[] sums = SumNegativeAndPozitive(myArray);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {sums[0]}");
// System.Console.WriteLine($"Сумма положительных элементов равна {sums[1]}");

//3.Решение с помощью out int переменной
int[] GeneretArray (int size, int leftRange, int rightRange)// на вход я получаю размер массива, левая граница и правая граница, создающая диапозон
{
    int[] array = new int[size];//выделим память размерностью size
    var rand = new Random();
    for(int i =0; i < array.Length; i++)
   {
    array[i] = rand.Next(leftRange, rightRange + 1);// -9, 9+1 //пройдусь по каждому элементу массива и присваиваю им рандомное значение
   } 
   return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(", ", array)+"]");//позводяет выводить элементы массива через заданный разделитель
}

void SumNegativeAndPozitive(int[] array, out int sumPositive, out int sumNegative)
{
   sumPositive = 0;//массив убрали, int впереди мы убрали, т.к. в обьявленной ф-ции там указали, но приписка out 
                    //означает, что из этого метода значения мы можем вытаскивать внезависимости произошел return или нет 
   sumNegative = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] < 0)//отрицательный элемент массива
        {
            sumPositive += array[i];//прибавим на 0-ую ячейку памяти резалта, в левую колонку
        }
        else{                       //иначе
            sumNegative += array[i];  //в правую ячуйку памяти запишем положительные элементы
        }
    }
}

int[] myArray = GeneretArray(12, -9, 9);
PrintArray(myArray);
SumNegativeAndPozitive(myArray, out int sumPositive, out int sumNegative);
System.Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
System.Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");