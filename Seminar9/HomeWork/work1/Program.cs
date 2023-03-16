// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число M:");
int N = int.Parse(Console.ReadLine());
void SumNumbers (int M, int N, int sum)
{
    if (M > N) 
    {
        System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    SumNumbers(M, N, sum);
}
SumNumbers(M, N, 0);