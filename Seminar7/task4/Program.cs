// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся 
//на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int [,] matrix = new int [rows, cols];
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(0,11);
        }
    }
    return matrix;
}
int SumElements(int[,] matrix)
{
    int SumElements = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                SumElements += matrix[i, j];
            }
        }
    }
    return SumElements;
}   
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");//табуляция нужна что цифры были друг под другом красиво
        }
        System.Console.WriteLine();
    }
}
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine(SumElements(myMatrix));

