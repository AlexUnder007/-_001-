// Напишите программу, которая 
// Принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находитмя эта точка.



Console.WriteLine("Введите коотрдинаты точки.");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc) // Quarter  - четверть
{
    if (xc > 0 && yc > 0) return 1;        //Координаты
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x,y);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют -> {quarter} четверти." // тернарный оператор ?(if) ТОГДА
                : "Введены некорректные координаты.";                          // :(else) ИНАЧЕ

Console.WriteLine(result);


// void Quarter(int xc, int yc) Другой вариант Void (Void не возвращает результат.) Так делать нельзя.
// {
//     if (xc > 0 && yc > 0) Console.WriteLine(1);       
//     else if (xc < 0 && yc > 0) Console.WriteLine(2);
//     else if (xc < 0 && yc < 0) Console.WriteLine(3);
//     else if (xc > 0 && yc < 0) Console.WriteLine(4);
//     else Console.WriteLine(result);
// }