// Напишите программу, которая 
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 ->120

Console.Write("Ввести число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
{
    int multiplay = 1; 
    for (int i = 1; i <= number; i++)
    {
        multiplay *= i;
    }
    return multiplay;
}


int factorial = Factorial(num);  //вызов метода
Console.WriteLine($"Проихведение чисел от 1 до {num} = {factorial}");