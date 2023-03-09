// Задача 47: Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
int ReadInt (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
    }
double[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    double [,] matrix = new double [rows, cols];
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 99)/10.0;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");//табуляция нужна что цифры были друг под другом красиво
        }
        System.Console.WriteLine();
    }
}    

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
