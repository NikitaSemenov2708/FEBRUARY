//Задача 10:** Показать вторую цифру трёхзначного числа.
Console.Clear();
/* void method(int number)
{
    if (number/100>=1&&number/100<=10)
    {
        Console.WriteLine(number/10%10);
    }
    else
    Console.WriteLine("Число не трехзначное");
    
}
method(2247); */
//Задача 12:** Удалить вторую цифру трёхзначного числа. 

/* void method(int number)
{
    if (number/100>=1&&number/100<=10)
    {
       // Console.WriteLine(number-number%100/10*10); в ноль делает второе число
       Console.WriteLine(number/10/10*10+number%10); //удалет цифру
    }
    else
    Console.WriteLine("Число не трехзначное");
    
}
method(596); */

//Задача 14:** Найти третью цифру числа или сообщить, что её нет.

/* void method(int number)
{
    if (number/100>=1)
    {   int value=number;
        int count=0;
       while (number/10>=1)
       {
           number=number/10;
           count++;
       }
       double separe=Math.Pow(10,(count-2));
       int del=Convert.ToInt32(separe);
        Console.WriteLine($"Третье число = {value/del%10}");
    }
    else
    Console.WriteLine("Третьего числа нет");
    
}
method(27489);  */

//Задача 16:** Дано число обозначающее день недели. Выяснить является номер дня недели выходным */

/* void method(int number)
{ 
    if (number>=1&&number<=5)
    {
        Console.WriteLine("Рабочий,вали на работу");
    }
    
    if (number>=6&&number<=7)
    {
        Console.WriteLine("Ура Выходной");
    } 
    if (number>=8||number==0)
    {
        Console.WriteLine("Введите день от 1 до 7");
    }
    
}
method(10); */
