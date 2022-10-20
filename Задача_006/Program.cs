/* 6. Напишите программу, которая 
на вход принимает число и 
выдаёт, является ли число чётным
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 1)
        {
            Console.Write($"{number} Число нечётное ");
        }
        else
        {
            Console.Write($"{number} Число чётное ");
        }
    }
}
