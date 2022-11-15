// Напишите программу, которая 
// принимает на вход (А) и 
// выдаёт сумму чисел. от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Ввести числа: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default;    // defaul значение по умолчанию. = 0
    
    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i; тоже самое
        sum += i;
    }
    return sum;
}


int sumNumbers = SumNumbers(num);  //вызов метода
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");







