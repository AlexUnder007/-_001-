/* 3. Написать программу, которая будет выдавать названия по заданному номеру.
3 -> Среда
5 -> Пятница
Console.Write("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine()); */

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
Console.WriteLine("Понедельник");
}
else if (number == 2)
{
Console.WriteLine("Вторник");
}
else if (number == 3)
{
Console.WriteLine("Среда");
}
else if (number == 4)
{
Console.WriteLine("Четверг");
}
else if (number == 5)
{
Console.WriteLine("Пятница");
}
else if (number == 6)
{
Console.WriteLine("Суббота");
}
else if (number == 7)
{
Console.WriteLine("Воскресенье");
}
if (number > 7)
{
Console.WriteLine("Прости, в неделе 7 дней");
}