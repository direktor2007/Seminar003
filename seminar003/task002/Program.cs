// Задача №18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.WriteLine("Введите номер четверти ");
int q = Convert.ToInt32(Console.ReadLine());

string [] array = {"x > 0 && y > 0","x < 0 && y > 0","x < 0 && y < 0","x > 0 && y < 0","Такой четверти не существует"};

 if(q == 1)
{
    System.Console.WriteLine(array[0]);
}
else if (q == 2)
{
    System.Console.WriteLine(array[1]);
}
else if (q == 3)
{
    System.Console.WriteLine(array[2]);
}
else if (q == 4 )
{
    System.Console.WriteLine(array[3]);
}
else 
{
    System.Console.WriteLine(array[4]);
}


//  if(q == 1)
// {
//     System.Console.WriteLine("x > 0 && y > 0");
// }
// else if (q == 2)
// {
//     System.Console.WriteLine("x < 0 && y > 0");
// }
// else if (q == 3)
// {
//     System.Console.WriteLine("x < 0 && y < 0");
// }
// else if (q == 4 )
// {
//     System.Console.WriteLine("x > 0 && y < 0");
// }
// else 
// {
//     System.Console.WriteLine("Такой четверти не существует");
// }
