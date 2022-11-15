// Программа, которая 
// принимает на вход число N и 
// показывает таблицу вкадратов

// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
// Math.Pow(2, 10) //возводить в степень
void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,4} -> {i * i,4} ");  //цифра это шаг, количество символов в строке.
        }
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}
SquareTable(n);