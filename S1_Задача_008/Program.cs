// 8. Напишите программу, которая 
// на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (num <= 0) 
{
    Console.Write("Вы ввели число меньше либо равное \"0\".");
}
else 
{
    Console.Write("Четные числа: ");
    while (count <= num) 
    { 
        if (count % 2 < 1) 
        {
            Console.Write($"{count} ");
        }
        count++;
    }
}