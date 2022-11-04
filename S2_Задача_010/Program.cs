// 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigit = number / 10;
    int result = secondDigit % 10;
    Console.WriteLine($"{result}");
}


else Console.Write("Надо ввести трёхначное число, попробуй ещё раз");