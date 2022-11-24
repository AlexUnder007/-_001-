// Напишите программу, которая 
// будет преобразовать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num) // Метод который переводит число в двоичное
// {
//     int result = 0;
//     while (num > 0)  
//     {
//         int dig1 = num % 2; // находим остаток от числа. Делим на 2 с остатком
//         result += dig1; // Присваиваем остаток к результату
//         result *= 10;   // Результат умножаем на 10
//         num /= 2;       // Делим число пополам
//     }
//     return result;
// }

// int ReverseNumber(int num2)      //  метод для разворота числа
// {
// int result = default;
// while (num2 >= 9)              // 9 чтобы работать с двузначными числами.
// {
// result += num2 % 10;        //присваеваем последнее число остатка делёного на 10
// result *= 10;              // умножаем на 10 чтобы получить двузначное число
// num2 /= 10;               // число делим на 10, отсекаем разряд.
// }
// result += num2 % 10;
// return result;
// }

// Console.WriteLine(ReverseNumber(ConvertToBin(number)));

// ______________________________________________________________________

// Console.WriteLine(" введите число в десятичной системе");
// int number = Convert.ToInt32(Console.ReadLine());

// int Binare(int num)
// {
// string st = "";
// while (num > 0)
// {
// string temp = Convert.ToString(num % 2);
// st = temp + st;
// num = num / 2;
// }

// int bin = Convert.ToInt32(st);
// return bin;
// }
// System.Console.WriteLine($"Число {number} в двоичной системе выглядит {Binare(number)}");


// ______________________________________________________________________
Console.WriteLine("Введите число десятичной системы исчисления");
int number10 = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num10)
{
int num2 = default;

while (num10 > 0)
{
num2 += num10 % 2;
num2 *= 10;
num10 /= 2;
ConvertToBin(num10);
}

return num2;
}

int ReverseNumber(int num2)
{
int result = default;

while (num2 > 9)
{
result += num2 % 10;
result *= 10;
num2 /= 10;
}
result += num2 % 10;

return result;
}

int number2Rev = ConvertToBin(number10);
int number2 = ReverseNumber(number2Rev);
Console.WriteLine(number2);