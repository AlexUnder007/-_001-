// Задайте массив из 12 элементов, 
// Заполненный случайными числами из промежутка [-9,0].
// Найдите сумму отрицательных и положительных элементов массива.
// Например:
// В массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int sise, int min, int max)     // метод создния массива 
{
    int[] array = new int[sise];
    Random rnd = new Random();
    for (int i = 0; i < sise; i++)
    {
        array[i] = rnd.Next(min, max + 1);          //заполняем массив
    }
    return array;
}

void PrintArray(int[] array)   // метод печати массива, вывода в консоль
{
    int sise = array.Length;   //это нужно, потому что sise использовали в другом методе.
    Console.Write("(");
    for (int i = 0; i < sise; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

int[] GetSumPositiveNegativeElem(int[] array) //Массив, метод вычесления, массив с которым будем работать.
{
    int sumPositive = 0;  // накопители положительных
    int sumNegative = 0;  // накопители отрицательных
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i]; //Если больше нуля то в сам позитив добавляем значение элемента.
        else sumNegative += array[i];             //Если отрицательное, то в самНегатив
    }
    return new int[]{sumPositive, sumNegative};  // создание нового массива
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}"); // [0] это индекс
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[1]}"); 