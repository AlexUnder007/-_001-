﻿// Напишите программу, 
// которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//  0 1 2 3 4   0 1 2 3 4
// [1,2,3,4,5] [5,4,3,2,1]

void ReverseArray(int[]array) // {} операторные скобки. Метод разворота массива.
{
    for (int i = 0; i < array.Length / 2; i++) //Нам нужна половина массива для разворота 1 с 5 и 2 с 4 поменять.Когда i равно 2, мы выходим из цикла.
    {
        int temp = array[i]; // записали значение первого элемента (1)
        array[i] = array[array.Length - 1 - i]; // тут записали значение последнего элемента (5) на место первого
        array[array.Length -1 - i] = temp; // тут записываем первый элемент на место 5(совершаем разворот)
    }
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
// Array.Reverse(arr); //Разворачивает массив
// PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);