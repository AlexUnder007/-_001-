// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A(3,6); B (2,1) ->5,09
// A(7,-5); B (1,-1) -> 7,21

// Math.Sqrt - извлечение корня

// double d = Math.Sqrt (45);
// double res = Math.Round(d,2);
// double d = 5.099997545;  //double  потому что дробное число
// double res


// double d = 5.099997545;  //double  потому что дробное число
// double res = Math.Round(d,2, MidpointRounding.ToZero); //стратегия окрегления
// Console.Write(res);

Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11,int x22, int y22)
{
    int rangeX = x11 - x22;
    int rangeY = y11 - y22;
    double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY);
    return rangeZ;
}

double result = Range(x1,y1,x2,y2);
Console.Write($"A({x1},{y1}); ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");