//Показать натуральные числа от 1 до N, N задано

/* string NumberLook(int n)
{
    string result= string.Empty;
    if(n==1) return result+n+" ";
    else return NumberLook(n-1)+n+" " ;
    
}
Console.WriteLine(NumberLook(10)); */
//Показать натуральные числа от M до N, N и M заданы

/* string NumberLook(int M, int N)
{
    //string result= string.Empty;
    if(M==N) return N.ToString();
    else return M+" "+NumberLook(M+1,N);
}
Console.WriteLine(NumberLook(10,20));  */

//Найти сумму цифр числа

 /* int number(int A)
{

    if(A<10) return A;
    else return A%10+(number(A/10));
}
Console.WriteLine(number(525));  */

//Написать программу возведения числа А в целую стень B

 /* int method (int A, int B)
{
    if(B==0) return 1;
    else return A*method(A,B-1);

}
Console.WriteLine(method(2,5)); */ 

//Показать натуральные числа от 1 до N, N задано

 /* string NumberLook(int n)
{
    return n == 1 ? n.ToString() : NumberLook(n-1)+" "+n;
    
}
Console.WriteLine(NumberLook(10)); */