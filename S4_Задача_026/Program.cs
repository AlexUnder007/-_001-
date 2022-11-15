// Напишите программу, которая 
// принимает на вход число и
// выдаёт кол-ло цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Если кол-во ицераций известно, используем fot
// Если неизвестно While

Console.Write("Ввести числа: ");
int num = Convert.ToInt32(Console.ReadLine());


int SumDigit(int number)
{
    number = Math.Abs(number); // (для отрицательных чисел) Меняет отрицательные на положительные.
    int count = 0;
    while (number > 0)
    {
        number = number /10;
        count++;
    }
    return count > 0 ? count : 1;   // чтобы и ноль засчитывало как число.
}

int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");
