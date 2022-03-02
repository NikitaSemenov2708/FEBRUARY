using System;

//собрать строку числам от a<=b

 /* string NumberFor (int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result+=$"{i} ";
    }
    return result;
}

Console.WriteLine(NumberFor(1,10)); 

string NumberRec(int a, int b)
{
    if(a<=b) return $"{a} " + NumberRec(a+1,b);
    else return String.Empty;
}
Console.WriteLine(NumberRec(1,10)); */

// рекурсия сумма чисел от 1 до N
/* int NumberRec(int n)
{
    if(n==0) return 0;
    else return n+NumberRec(n-1);
}
Console.WriteLine(NumberRec(10)); */

// Факториал Числа
/* int Factorial (int n)
{
    if(n==0) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(4)); */

// Вычислить A в степени N
/* int number (int n, int A)
{
    if(n==1) return n=A;
    else return A*number(n-1,A);
}
Console.WriteLine(number(3,3)); */
// Cоставление различных возможных сочетаний
/* int n =1;
void FineWords (string alphabet, char[] word, int length=0  )
{
    if(length==word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length]=alphabet[i];
        FineWords(alphabet, word, length+1);
    }

}
FineWords("aисв", new char[2]); */
//!!!!!!!!!!!!!!!!!!!! Не запускается!!!!!!!!!!!!!!
/* using system Linq;
string path = " /Users/Home/Desktop/Разработчик/Знакомство с языком программирования С#/homework_7/Lection_7/Program.cs";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo fi= di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
 */