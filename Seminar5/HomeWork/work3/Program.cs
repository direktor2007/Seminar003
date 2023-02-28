// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        return max;
    }
}
double FindMin(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) ;
        {
            min = array[i];
        }
        return min;
    }
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int[] array = GeneretArray(10, -100, 100);
PrintArray(array);
double max = FindMax(array);
double min = FindMin(array);
Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

