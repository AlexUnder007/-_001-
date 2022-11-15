// Напишите программу, которая 
// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,11,0,1,0,0]
//  0 1  2 3 4 5 6
Console.Write("Введите число элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)  // Объявляем массив
{
    int[] array = new int[size]; // создание массива
    Random rnd = new Random();   // Рандомные числа
    for (int i = 0; i < array.Length; i++)   // движение мо масиву
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}



void PrintArray(int[] array)  // Передаём значение массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)   // движение мо масиву
    {
        if(i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int[] nameArray = NameArray(num);
PrintArray(nameArray);

