// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] GeneretArray(int size, int leftRange, int rightRange)//здесь мы задаем некий массив генерирующий случайные числа
{                                       //внизу выводим его на печать
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] GetResult(int[] array)//здесь эта ф-ция возвращает второй массив, а на вход она принимает массив из первой функции
{
    int size;// здесь мы определяем размерность второго массива
    if (array.Length % 2 == 0) //если исходный массив имеет четное колво элементов, то длина нового массива будет половина
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;//если нечетное кол эл имеет исходный массив, то длина нового будет половина +1 элемент
    }

    int[] arRresult = new int[size];//здесь мы задали новый массив и опредлели его размерность size, описанный выше
    for (int i = 0; i < size; i++)//здесь изменяем i до эл-ов нового массива
    {
        arRresult[i] = array[i] * array[array.Length - 1 - i];//первый(нулевой) эл-т нового массива равен =
    }//первый эл-т старого массива*длина старого массива-1 и -i,т.е 7 эл - 1 - i= 6 - это последний эл-т в первом массиве
    if (array.Length % 2 != 0)//это условие если массив имеет нечетную длину, 
    {//чтобы серединный эл-т сам на себя не перемножался
        arRresult[arRresult.Length - 1] = array[size - 1];//последний эл-т нового массива равен серединному эл-ту
    }
    return arRresult;//возвращает новый массив
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] myArray = GeneretArray(5, 1, 10);
PrintArray(myArray);
int[] newArray = GetResult(myArray);
PrintArray(newArray);
