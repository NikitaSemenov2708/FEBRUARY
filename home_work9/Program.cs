//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/* string method (int m, int n)
{
    if(m==n) return n.ToString();
    else return  m.ToString()+" "+method(m+1,n);

}
Console.WriteLine(method(2,5)); */
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

 /* int method (int m, int n)
{   
   if(m==n) return m;
    else return  m+method(m+1,n);
}
Console.WriteLine(method(1,5));  */

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.//не пойму ругается что не все пути возвращаю

 int method (int m, int n)
{
    if(m == 0) return n+1;
    else if(m>0&&n==0) return method(m-1,1);
    else if(m > 0&&n>0) return method(m-1,method(m,n-1));
    else return 0;

}
Console.WriteLine(method(0,5)); 
 