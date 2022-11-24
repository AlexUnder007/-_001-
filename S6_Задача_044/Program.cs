// Не используя рекурсию, 
// выведите первые N числа Фибоначи. 
// Первые два числа фибоначи; 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число десятичной системы исчисления");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonachi(int num)
{
    int[]arrayFibonachi = new int[num];
    arrayFibonachi[1] = 1; // первому элементу массива присваеваем значение 1(по умолчанию массив заполнен нулями.)
    for (int i = 2; i < num; i++)
    {
        arrayFibonachi[i] = arrayFibonachi[i - 1] + arrayFibonachi[i - 2]; //Числу присваиваем значение двух предыдущих чисел.
    }
    return arrayFibonachi;
}

void PrintArray(int[] array) //Печать массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] fibonachi = Fibonachi(number);
PrintArray(fibonachi);