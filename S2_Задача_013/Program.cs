// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) ;
{
    Console.WriteLine("Третьего числа нет");
}
else if (number < 1000) ;
{
    int thirdDigit = number % 10;
    int result = thirdDigit;
    Console.WriteLine($"{result}");
}
while (number > 999) ;
{
    number = number / 10;
    int number2 = number;
}
if (number2 < 1000)
{
    int thirdDigit = number % 10;
    int result2 = thirdDigit;
    Console.WriteLine($"{result2}");
}
