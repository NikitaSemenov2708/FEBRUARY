//Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.

/* Console.WriteLine("Введите числа");
string[] names = Console.ReadLine().Split(" ");
int count=0;
 for (int i = 0; i < names.Length; i++)
{

    if (Convert.ToInt32(names[i])>0)
    {
        count++;
    }
}  
Console.WriteLine($"Количесвто чисел введеных с клавиатуры больше 0 = {count}"); */


//Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
/* void crosss (double b1, double k1, double b2, double k2 )
{
    double k=0;
    double b=0;
    double resultx=0;
    double resulty=0;
    if (k1!=k2)
    {
        k= k1-k2;
        b= b2-b1;
        resultx= b/k;
        resulty= k1*resultx+b1;

    }
    Console.WriteLine($"Точка пересечения фигуры = {resultx};{resulty}");
}
crosss(2, 1, 5, 4); */

//Задача 46: Написать программу масштабирования фигуры
/* void cros (double x1, double y1, double x2, double y2, double k)
{
    x1=k*x1;
    x2=k*x2;
    y1=k*y1;
    y2=k*y2;
    Console.WriteLine($"({x1};{y1}) , ({x2};{y2})");
}
cros(1,3,5,2,0.5); */

/* Console.SetCursorPosition(Convert.ToInt32(x1), Convert.ToInt32(y1)); // если нужа картинка в терминале
Console.WriteLine("+");
Console.SetCursorPosition(Convert.ToInt32(x2), Convert.ToInt32(y2));
Console.WriteLine("+"); */

/* Для тех, кто ушёл далеко вперёд, — усложнение.
Сделать так, чтобы:
1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
3. В результате были выводились полученные координаты.
При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" */

/* Console.WriteLine("Введите числа через пробел");
string[] numbers = Console.ReadLine().Split(" ");
Console.WriteLine(" Введите Коэффициент масштабирования k");
string[] zoom = Console.ReadLine().Split(" ");
string result= " ";
 for (int i = 0; i < numbers.Length; i++)
{
    result= result + Convert.ToString(Convert.ToInt32(numbers[i])*Convert.ToInt32(zoom[0])+" ");
    
}  
Console.WriteLine(result); */