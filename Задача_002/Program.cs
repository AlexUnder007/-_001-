// 2: Напишите программу, которая 
// на вход принимает два числа
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"Наибольшее число: {number1} Наименьшее: {number2}");
}
else if (number1 < number2)
{
    Console.Write($"Наибольшее число: {number2} Наименьшее: {number1}");
}
    
