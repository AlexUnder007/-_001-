// Напишите программы, которая 
// по заданному номеру четверти, 
// показывает диапозон возмозных координат точек в этой области.



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