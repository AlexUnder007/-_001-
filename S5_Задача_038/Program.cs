





double[] CreateArrayRndDouble(int size, int min, int max) // Тут тоже можно использовать не Int а double для десятых и сотых чисел.
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;// Формула для диапозона нужных вещественных чисел
        array[i] = Math.Round(NullableComparer -1);   // Округление чисел
    }
    return array;
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

