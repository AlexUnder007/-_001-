/* 3. Написать программу, которая будет выдавать названия по заданному номеру.

Console.Write("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine()); */

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
Console.WriteLine("Понедельник");
}
if (number == 2)
{
Console.WriteLine("Вторник");
}
if (number == 3)
{
Console.WriteLine("Среда");
}
if (number == 4)
{
Console.WriteLine("Четверг");
}
if (number == 5)
{
Console.WriteLine("Пятница");
}
if (number == 6)
{
Console.WriteLine("Суббота");
}
if (number == 7)
{
Console.WriteLine("Воскресенье");
}
if (number > 7)
{
Console.WriteLine("Прости, в неделе 7 дней");
}