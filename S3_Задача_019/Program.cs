// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


// 1 2 3 4 5  Надо сравнить 1 и 5, 2 и 4.

int num1 = num / 10000;     // 1
int num2 = num / 1000 % 10; // 2
int num4 = num / 10 % 10;   // 4
int num5 = num % 10;        // 5

if (num <= 99999 && num >= 10000)
{
    if (num1 == num5 && num2 == num4) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
else Console.WriteLine("Введно не пятичначное число");

