/* 9. Напишите программу, которая:
выводит случайное число из отрезка [10, 99]
показывает наибольшую цифру числа.
Primer:
78 -> 8
12-> 2
85 -> 8  */

int number = new Random().Next(10, 100); //Последее число не включается в диапозон.
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 / 10 = 8

if(firstDigit > secondDigit) 
Console.WriteLine($"Наибольшая цифра цисла равна {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {secondDigit}");

// int res = Math.Max(firstDigit, secondDigit); //встроенная матиматическая формула на поиск большего числа
// Console.WriteLine(res); 

// Условный оператор
int result = default;  // default условно обозначает 0. int count = 0, на счётчике опозначается 0
if(firstDigit > secondDigit) result = firstDigit; 
else result = secondDigit;
Console.WriteLine($"Наибольшая цифра {result}"); 


// Тернарный оператор.      ? - означает, если условие выполняется, тогда это число применяется
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");


// Тернарный оператор 2
Console.Write($"Наибольшая цифра числа {number} равна ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

