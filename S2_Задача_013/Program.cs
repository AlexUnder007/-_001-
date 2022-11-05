// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
int ThirdDigit(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}
int result = ThirdDigit(number);
Console.Write($"{result}");
}
if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}
