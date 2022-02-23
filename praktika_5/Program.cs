//Выяснить являются ли три числа сторонами треугольника// ПРЯМОУГОЛЬНЫМ
//Написать программу преобразования десятичного числа в двоичное (8)

/* void met(int x, int y, int z)
{
    if (x+y>z&&x+z>y&&y+z>x)
    {
        Console.WriteLine("Данные числа являются сторонами треугольника");
    }
    else
    {
        Console.WriteLine("Данные числа НЕ являются сторонами треугольника");
    }

}
met(3,4,5); */


/*  void met(int x, int y, int z) //ПРЯМОУГОЛЬНЫМ
{
    if (Math.Sqrt((x*x)+(y*y))==Math.Sqrt(z*z)|| Math.Sqrt((x*x)+(z*z))==Math.Sqrt(y*y)||Math.Sqrt((z*z)+(y*y))==Math.Sqrt(x*x))
    {
        Console.WriteLine("Данные числа являются сторонами прямоугольного треугольника");
    }
    else
    {
        Console.WriteLine("Данные числа НЕ являются сторонами прямоугольного треугольника");
    }
}
met(6,8,11);  */
//

 //Написать программу преобразования десятичного числа в двоичное (8)

 /* int change (int number)
{
    if (number>1) return number/2;
    else return change(number%2);

 }
 int per =change( 25);
 Console.WriteLine(per);  */

/*  void change (int number)
 {  
     int num = number;
     string result = string.Empty;
     while (number>0)
     {
         result=  $"{number%2}"+result;
         number=number/2;  
     }   
     Console.Write(result);
 }

 change(19); */

 int Fibonacci(int n)
 {   
     if(n==1||n==2) return 1;
     else return Fibonacci(n-1) + Fibonacci(n-2);
 }
 int num= int.Parse(Console.ReadLine());
 for (int i = 1; i < num; i++)
 {
     Console.WriteLine(Fibonacci(i));
 }