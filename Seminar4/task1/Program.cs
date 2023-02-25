// Задача 24: Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10 1+2+3+4=10
// 8 -> 36
// 1. Решение простое
// System.Console.WriteLine("Введите число А: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i =1; i<=num; i++)
// {
//    result +=i; 
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");
// 2. Решение чере функцию
int GetNumber(string text)
{
   System.Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}

int GetSumElens(int A)
{
   int result = 0;
   for (int i =1; i<=A; i++)
{
 result +=i; 
}
return result;
}
int num = GetNumber("Введите число А: ");
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumElens(num)}");

//метод получает строку (введите число А). переменная int равна вызов метода с такой строкой
//строка выводится в терминал и возвращает функция int значение, когда она вернет значение она помесить в переменную num
