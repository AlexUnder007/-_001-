// Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int sum, int number);
{
    int count = 0;
    int number = 0;
    int sum = 0;
    while (number > 0)
    {
        number = number / 10;

        sum = sum + number;
        count++;
    }
    return sum; // чтобы и ноль засчитывало как число.
}
int Summa = SumOfNumbers(num);
Console.WriteLine($"{num} ->");
