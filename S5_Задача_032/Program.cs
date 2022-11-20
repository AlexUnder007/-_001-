// Напишите программу замена элемонтов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// Пример:
// [-4,-8,8,2],->[4,8,-8,-2]

int[] CreateArrayRndInt(int size, int min, int max) //создаём массив
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void InversionArray(int[] arr)  //изменяем исходный массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

void PrintArray(int[]array)
{
    Console.Write(",");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]},");
    }
    Console.WriteLine(")");
}

int[] array = CreateArrayRndInt(18, -10, 10); //вызываем метод, который создаём массив
PrintArray(array);//выводим первый
InversionArray(array); //инвертируем массив
PrintArray(array);//выводим второй
