// 11. Напишите программу, которая 
// выводит случайноетрёхзначное число и 
// удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); //Последее число не включается в диапозон.
Console.WriteLine($"Крайние цифры трёхзначного числа {number}");

// int firstDigit = number / 100; // 78 / 10 = 7
// int thirdDigit = number % 10; // 78 / 10 = 8

// int digit = firstDigit*10 + thirdDigit; 

// Console.WriteLine($"{digit}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100; // 78 / 10 = 7
    int thirdDigit = num % 10; // 78 / 10 = 8
    return firstDigit * 10 + thirdDigit;
}

int result = DelSecondDigit(number);
Console.WriteLine($"Полученное число {result}");
