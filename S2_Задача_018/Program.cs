// Напишите программы, которая 
// по заданному номеру четверти, 
// показывает диапозон возмозных координат точек в этой области.


Console.WriteLine("Введите коотрдинаты точки.");
int quarter = Convert.ToInt32(Console.ReadLine());


string Quarter(int quarterXY) // Quarter  - четверть
{
    if (quarterXY==1) return "x > 0, y > 0";        //Координаты
    if (quarterXY==2) return "x < 0, y > 0";
    if (quarterXY==3) return "x < 0, y < 0";
    if (quarterXY==4) return "x > 0, y < 0";
    return "введён некорректный номер сетверти";
}

string xy = Quarter(quarter);
Console.Write($"Диапозон координат для четверти {quarter}: ");
Console.WriteLine(xy);


// string result = quarter > 0 
//                 ? $"Указанные координаты соответствуют -> {quarter} четверти." // тернарный оператор ?(if) ТОГДА
//                 : "Введены некорректные координаты.";                          // :(else) ИНАЧЕ

// Console.WriteLine(result);