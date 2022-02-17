//ЗАДАЧИ
/* Задача 26: Возведите число А в натуральную степень B, используя цикл.
Задача 28: Подсчитайте сумму цифр в числе.
Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру
Задача 32:Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран */
//Задача 26: Возведите число А в натуральную степень B, используя цикл.

/* double met (double a, double b)
{
    double res=0;
    while (a!=0)
    {
        res= Math.Pow(a,b);
        break;
    }
    return res;
    
}
double quadro = met(4, 2);
Console.WriteLine(quadro); */

/* int met (int a, int b)
{
    int res=1;
    
    while (b!=0)
    {
        res=res*a;
        b--;
        Console.WriteLine(b);
        
    }
    return res;
    
}
int quadro = met(2, 5);
Console.WriteLine();
Console.WriteLine(quadro); */

//Задача 28: Подсчитайте сумму цифр в числе.

/* int method (int number)
{
    
    int res=0;
    while (number%10>0)
    {
        res=res+number%10;
        number=number/10;
    }
    return res;
}
int num = method(5254);
Console.WriteLine(num); */
//Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
/* int n= int.Parse(Console.ReadLine());
int[] arr = Enumerable.Range(1,n).ToArray();

    foreach (int item in arr)
{
    double Pow = Math.Pow(item,3);
    if (Pow%2==0)
    {
        Console.WriteLine(Pow);
    }
} */



//Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран 
/* 
int getRandom ()
{

    return new Random().Next(0, 2);
}

int[] N= new int[8];
int index=0;
while (index<8)
{
     N[index]=getRandom();
     index++;
}

index=0;

while (index<8)
{
Console.Write(N[index]);
index++;
} */