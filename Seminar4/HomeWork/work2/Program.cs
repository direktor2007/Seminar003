//  Задача 27: Напишите программу, которая принимает 
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumber(int N)
{
    int A = Convert.ToString(N).Length;
    int C = 0;
    int result = 0;
    for (int i = 0; i < A; i++)
    {
        C = N - N % 10;
        result = result + (N - C);
        N = N / 10;
    }
    return result;
}
int sumNumber = SumNumber(N);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);