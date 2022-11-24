// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)  //Создание массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int[] MultiplicftionNumbers(int[] array)
{
    int size = array.Length / 2;   //Размер массива делить на 2
    if (array.Length % 2 == 1) size = size + 1; //определили размер для нового массива
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++) //пройти половину массива
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2]; //Проверка на чётность

    return newArray;
}





int[] arr = CreateArrayRndInt(5, 1, 9); //размер массива и диапозон от 1 до 9
PrintArray(arr);

int[] result = MultiplicftionNumbers(arr);
PrintArray(result);


//Умножаем 1 и 5 число, 2 и 4 число. 3 чмсло просто записываем.