// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// System.Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= N)
// {
//     System.Console.Write(Math.Pow(count, 2) + ", ");
//     count++;
// }

//Так как у нас есть окончательное число действий (количество итераций), то лучше через for

System.Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= N; count++)
{
    System.Console.Write(Math.Pow(count, 2) + ", ");
}
//Решение через функцию
// void PrintSquares(int x)
// {
// for (int i = 1; i <= x; i++)
// {
// System.Console.Write(Math.Pow(i, 2) + " ");
// }
// }

// System.Console.WriteLine("Введите число N");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// PrintSquares(a);