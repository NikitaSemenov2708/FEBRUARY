//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
/* bool a (bool x, bool y)
{
  bool res = true;
  if (!(x|y) == (!x && !y))
  {   
      return res;
  }
    else
    {
       res= false;
       return res;
    }

}

bool var = a(true, true); 
Console.WriteLine(var);
Console.WriteLine();

var = a(false, true); 
Console.WriteLine(var);
Console.WriteLine();

var = a(true, false); 
Console.WriteLine(var);
Console.WriteLine();

var = a(false, false); 
Console.WriteLine(var); */

//Задать номер четверти, показать диапазоны для возможных координат
/* string a (int number)
{
  string res=string.Empty;
    if (number==1)
    {
        res="Данная четверть принимает значения x (0....100], y (0....100] ";
        return res;
    }
    if (number==2)
    {
        res="Данная четверть принимает значения x [-100....0), y (0....100] ";
        return res;
    }
    if (number==3)
    {
        res="Данная четверть принимает значения x [-100....0), y (-100....0] ";
        return res;
    }
    if (number==4)
    {
        res="Данная четверть принимает значения x (0....100], y (-100....0] ";
        return res;
    }
    else
    {
        res="Неправильно введен номер четверти";
        return res;
    }
}

string num= a(1);
Console.WriteLine(num); */

//Найти расстояние между точками в пространстве 3D
/* double a (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance=0;
    distance= Math.Pow((Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)), (1.0/3.0));
    return distance;
}
double result = a(1, 4, 1, 4, 1, 4);
Console.WriteLine(result); */

//Найти кубы чисел от 1 до N
/* string met(int arg)
{
    var res = " ";
    for (int i = 1; i <= arg; i++)
    {
        res += i * i * i + " ";//res+ будет возвращать каждое число в данном цикле, +" " для разделения чисел , тип данных var можно использовать как для int так и для string
    }
    return res;
}
Console.WriteLine(met(5)); */
