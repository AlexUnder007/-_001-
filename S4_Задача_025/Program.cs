﻿// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

int DegreeOfNumber(int numA, int numB)
{
    int count = 1;
    int num = 1;
    while (count <= numB)
    {
        num = num * numA;
        count++;
    }
    return num;
}

int num = DegreeOfNumber(numberA, numberB);
Console.WriteLine($"{numberA},{numberB} -> {num}");