// Напишите программу: которая
// принимает на вход три числа и 
// проверяет: может ли существовать треугольник с сторонами такой длины]»

// Каждая сторона треугольника меньше ссуммы двух сторон

Console.WriteLine("Веедите три числа через Enter");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

bool IsExsistTriangle(int numberA, int numberB, int numberC)
{
    bool b = numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB; //Условие. Каждая сторона треугольника меньше ссуммы двух сторон
    return b;
}

bool isExsistTriangle = IsExsistTriangle(num1,num2,num3);
Console.WriteLine(isExsistTriangle);