// 4. Напишите программу, которая 
// принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// Пример : 2, 3, 7 -> 7
        //  44, 5, 78 -> 78
        //  22, 3, 9 -> 22



Console.WriteLine("Введите 3 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int Max = 0;

if ((number1 > number2) && (number1 > number3))
Max = number1;
else if ((number2 > number1) && (number2 > number3))
Max = number2;
else if ((number3 > number1) && (number3 > number2))
Max = number3;
Console.Write("Самое большое число: ");
Console.WriteLine(Max);